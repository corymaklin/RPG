using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.GameFoundation;
using UnityEngine.GameFoundation.DefaultLayers;
using UnityEngine.Promise;

namespace _Project.Scripts.Managers
{
    public class SaveManager : Singleton<SaveManager>
    {
        [SerializeField] private string saveName = "GameSave";
        [SerializeField] private Skills skills;
        [SerializeField] private Stats stats;
        private void Awake()
        {
            if (File.Exists($"{Application.persistentDataPath}/{saveName}.save"))
            {
                Debug.Log("[SaveManager]: Save found. Loading data...");
                
                // Synchronous
                // Load($"{Application.persistentDataPath}/{saveName}.save");
                skills.Initialize();
                stats.Initialize(true);
            }
            else
            {
                Debug.Log("[SaveManager]: No save found. Initializing player stats...");
                skills.Initialize();
                stats.Initialize(true);
            }
        }
        
        private IEnumerator WaitForSaveCompletion(Deferred saveOperation)
        {
            // Wait for the operation to complete.
            yield return saveOperation.Wait();

            LogSaveOperationCompletion(saveOperation);
        }

        private void LogSaveOperationCompletion(Deferred saveOperation)
        {
            // Check if the operation was successful.
            if (saveOperation.isFulfilled)
            {
                Debug.Log("Saved!");
            }
            else
            {
                Debug.LogError($"Save failed! Error: {saveOperation.error}");
            }
        }
        
        public void Save()
        {
            Dictionary<string, object> dict;
            
            if (File.Exists($"{Application.persistentDataPath}/{saveName}.save"))
            {
                // To avoid losing the data for objects not in the current scene 
                dict = LoadFile($"{Application.persistentDataPath}/{saveName}.save");
            }
            else
            {
                dict = new Dictionary<string, object>();
            }
         
            foreach (var savable in FindObjectsOfType<SavableEntity>())
            {
                dict[savable.Id] = savable.SaveData();
            }
            
            SaveFile($"{Application.persistentDataPath}/{saveName}.save", dict);
            
            // Get the persistence data layer used during Game Foundation initialization.
            if (!(GameFoundationSdk.dataLayer is PersistenceDataLayer dataLayer))
                return;

            // - Deferred is a struct that helps you track the progress of an asynchronous operation of Game Foundation.
            // - We use a using block to automatically release the deferred promise handler.
            using (Deferred saveOperation = dataLayer.Save())
            {
                // Check if the operation is already done.
                if (saveOperation.isDone)
                {
                    LogSaveOperationCompletion(saveOperation);
                }
                else
                {
                    StartCoroutine(WaitForSaveCompletion(saveOperation));
                }
            }
        }

        public void Load(string path)
        {
            Dictionary<string, object> dict = LoadFile(path);
            
            foreach (var savable in FindObjectsOfType<SavableEntity>())
            {
                if (dict.TryGetValue(savable.Id, out object data))
                {
                    savable.LoadData(data);
                }
            }
        }
        
        private void SaveFile(string path, object saveData)
        {
            using (FileStream file = File.Open(path, FileMode.Create))
            {
                BinaryFormatter formatter = GetBinaryFormatter();
                
                try
                {
                    formatter.Serialize(file, saveData);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                finally
                {
                    file.Close();
                }
            }
        }
        
        private Dictionary<string, object> LoadFile(string path)
        {
            BinaryFormatter formatter = GetBinaryFormatter();

            FileStream file = File.Open(path, FileMode.Open);

            try
            {
                object saveData = formatter.Deserialize(file);
                return saveData as Dictionary<string, object>;
            }
            catch (Exception e)
            {
                Debug.Log($"Failed to load file at {path}");
                return new Dictionary<string, object>();
            }
            finally
            {
                file.Close();
            }
        }
        
        private BinaryFormatter GetBinaryFormatter()
        {
            BinaryFormatter formatter = new BinaryFormatter();
        
            SurrogateSelector selector = new SurrogateSelector();
        
            Vector3SerializationSurrogate vector3Surrogate = new Vector3SerializationSurrogate();
            QuaternionSerializationSurrogate quaternionSurrogate = new QuaternionSerializationSurrogate();
            
            selector.AddSurrogate(typeof(Vector3), new StreamingContext(StreamingContextStates.All), vector3Surrogate);
            selector.AddSurrogate(typeof(Quaternion), new StreamingContext(StreamingContextStates.All), quaternionSurrogate);
        
            formatter.SurrogateSelector = selector;
        
            return formatter;
        }
    }
}
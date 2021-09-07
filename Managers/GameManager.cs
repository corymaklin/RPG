using System.Collections;
using UnityEngine;
using UnityEngine.GameFoundation;
using UnityEngine.GameFoundation.DefaultCatalog;
using UnityEngine.GameFoundation.DefaultLayers;
using UnityEngine.GameFoundation.DefaultLayers.Persistence;
using UnityEngine.Promise;

namespace _Project.Scripts.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        private CatalogAsset currentCatalog;
        private readonly string localPersistenceFilename = "GameFoundationSave";
        
        private void OnDestroy()
        {
            if (!GameFoundationSdk.IsInitialized)
            {
                Debug.Log("Game Foundation is not initialized.");
                return;
            }

            GameFoundationSdk.Uninitialize();
        }
        
        private IEnumerator Start()
        {
            PersistenceDataLayer dataLayer = new PersistenceDataLayer(
                new LocalPersistence(
                    localPersistenceFilename,
                    new JsonDataSerializer()
                ),
                currentCatalog
            );
            
            // Asynchronous
            using (Deferred initialization = GameFoundationSdk.Initialize(dataLayer))
            {
                if (!initialization.isDone)
                {
                    yield return initialization.Wait();
                }
                
                if (!initialization.isFulfilled)
                {
                    Debug.LogError(initialization.error);
            
                    yield break;
                }
            }
        }
    }
}
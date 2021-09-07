using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Scripts.Managers
{
    public class LevelManager : MonoBehaviour, ISavable
    {
        public string currentSceneName;
        private void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;
        }

        private void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.sceneUnloaded -= OnSceneUnloaded;
        }

        private void Start()
        {
            if (String.IsNullOrEmpty(currentSceneName))
                currentSceneName = Constants.SCENE.CHARACTER_SELECTION;
            
            SceneManager.LoadScene(currentSceneName, LoadSceneMode.Additive);
        }

        private void OnSceneUnloaded(Scene scene)
        {
            switch (scene.name)
            {
                case Constants.SCENE.CHARACTER_SELECTION:
                    UIManager.Instance.Hide();
                    break;
                default:
                    
                    break;
            }
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            if (scene.name == Constants.SCENE.BASE || scene.name == Constants.SCENE.VR_BASE)
                return;

            currentSceneName = scene.name;
            
            switch (currentSceneName)
            {
                case Constants.SCENE.CHARACTER_SELECTION:
                    UIManager.Instance.Show(Constants.UI.CHARACTER_SELECTION);
                    break;
                case Constants.SCENE.TUTORIAL:
                    break;
                default:
                    
                    break;
            }
        }

        public object SaveData()
        {
            return new LevelData
            {
                currentSceneName = currentSceneName
            };
        }

        public void LoadData(object data)
        {
            LevelData levelData = (LevelData) data;
            currentSceneName = levelData.currentSceneName;
        }
    }
}
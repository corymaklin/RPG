using UnityEngine;

namespace _Project.Scripts
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;
        public static T Instance {
            get
            {
                if (instance == null)
                {
                    var gos = FindObjectsOfType(typeof(T)) as T[];

                    if (gos.Length > 0)
                        instance = gos[0];
                    
                    if (gos.Length > 1)
                        Debug.LogError($"[Singleton] There is more than one instance of {typeof(T).Name} in the scene");

                    if (instance == null)
                    {
                        GameObject go = new GameObject();
                        go.hideFlags = HideFlags.DontSave;
                        instance = go.AddComponent<T>();
                        DontDestroyOnLoad(go);
                    }
                }

                return instance;
            }
        }
    }
}
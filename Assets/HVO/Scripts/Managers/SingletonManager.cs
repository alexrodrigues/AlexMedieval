using UnityEngine;

public abstract class SingletonManager<T> : MonoBehaviour where T : MonoBehaviour
{
    protected virtual void Awake()
    {
        T[] managers = FindObjectsByType<T>(FindObjectsSortMode.None);
        if (managers.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
    }

    public static T Get()
    {
        var tag = typeof(T).Name;
        GameObject gameManager = GameObject.FindWithTag(tag);
        if (gameManager != null)
        {
            return gameManager.GetComponent<T>();
        }

        GameObject container = new GameObject(tag);
        gameManager.tag = tag;

        return container.AddComponent<T>();
    }
}

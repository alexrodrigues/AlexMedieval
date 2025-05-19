using UnityEngine;

public class GameManager : MonoBehaviour
{
    protected virtual void Awake()
    {
        GameManager[] managers = FindObjectsByType<GameManager>(FindObjectsSortMode.None);
        if (managers.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
    }

    public static GameManager Get()
    {
        var tag = nameof(GameManager);
        GameObject gameManager = GameObject.FindWithTag(tag);
        if (gameManager != null)
        {
            return gameManager.GetComponent<GameManager>();
        }

        GameObject container = new GameObject(tag);
        gameManager.tag = tag;

        return container.AddComponent<GameManager>();
    }


    public void Test() {
        Debug.Log("Test");
    }
}

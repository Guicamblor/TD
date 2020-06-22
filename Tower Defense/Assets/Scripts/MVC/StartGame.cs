using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameManager jogoPrefab;
    static StartGame _instance;


    void Awake()
    {
        _instance = this;
    }

    public static GameManager BeginGame()
    {
        return Instantiate(_instance.jogoPrefab);
    }

    public static void EndGame()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        GameObject.Destroy(gameManager.gameObject);
    }

}

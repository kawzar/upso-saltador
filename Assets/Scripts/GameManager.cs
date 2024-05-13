using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float rapidezActores = 1.5f;
    [SerializeField] private Canvas gameOverCanvas;
    private static GameManager instance;
    private bool estaJugando = false;
    public bool EstaJugando => estaJugando;

    public static GameManager Instance => instance;
    public float RapidezActores => rapidezActores;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        estaJugando = true;
    }

    public void Perder()
    {
        estaJugando = false;
        gameOverCanvas.gameObject.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}

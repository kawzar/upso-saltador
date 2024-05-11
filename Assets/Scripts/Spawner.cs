using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy[] prefabEnemigo;

    [SerializeField] private float spawnTime;

    [SerializeField]
    [Range(0, 1)] private float spawnChance;

    private float ultimoSpawnTime = 0;

    private void Start()
    {
        transform.position = new Vector3(Screen.width + 3, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if (Time.time - ultimoSpawnTime > spawnTime)
        {
            if (Random.Range(0, 1) <= spawnChance)
            {
                Instantiate(prefabEnemigo[Random.Range(0, prefabEnemigo.Length)], transform.position, Quaternion.identity);
                ultimoSpawnTime = Time.time;
            }
        }
    }
}

using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;

    private float _spawnDelay = 2.0f;
    private float _spawnTimer = 0;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), _spawnTimer, _spawnDelay);
    }

    private void Spawn()
    {
        int spawnPointIndex = Random.Range(0, _spawnPoints.Length);
        Vector3 direction = GetRandomDirection();

        SpawnPoint spawnPoint = _spawnPoints[spawnPointIndex];
        Enemy enemy = spawnPoint.Spawn(_enemyPrefab);
        enemy.Init(direction);
    }

    private Vector3 GetRandomDirection()
    {
        float x = Random.Range(-1.0f, 1.0f);
        float z = Random.Range(-1.0f, 1.0f);

        return new Vector3(x, 0, z);
    }
}

using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Enemy Spawn(Enemy enemyPrefab)
    {
        return Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPos.transform.position, enemyPrefab.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPF;
    private float spawnRange = 9;
    public int noOfObject;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < noOfObject; i++)
        {
            Instantiate(enemyPF, GeneratePosition(), enemyPF.transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    private Vector3 GeneratePosition()
    {
        float spawnPX = Random.Range(-spawnRange, spawnRange);
        float spawnPZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPX, 0, spawnPZ);

        return randomPos;

    }


}

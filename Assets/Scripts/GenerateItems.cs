using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateItems : MonoBehaviour
{
    [SerializeField] GameObject[] presents;
    [SerializeField] int numOfPresents = 30;
    [SerializeField] Vector3 spawnAreaSize = new Vector3 (0, 0, 0);
    [SerializeField] float posY = 10f;
    // Start is called before the first frame update
    void Start()
    {
        GenerateItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateItem()
    {
        for (int i = 0; i < numOfPresents; i++)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            int itemNo = Random.Range(0, presents.Length);
            Instantiate(presents[itemNo], spawnPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randX = Random.Range(-spawnAreaSize.x/2f, spawnAreaSize.x/2f);
        float randZ = Random.Range(-spawnAreaSize.z/2f, spawnAreaSize.z/2f);

        Vector3 spawnPosition = new Vector3(randX, posY, randZ);

        return spawnPosition;
    }
}

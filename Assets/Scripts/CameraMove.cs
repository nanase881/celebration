using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        Vector3 playerPos = player.transform.position;
        cameraPos.x = playerPos.x;
        cameraPos.y = playerPos.y + 3;
        cameraPos.z = playerPos.z - 5;

        transform.position = cameraPos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraxaxis = 0f;
    public float camerayaxis = 0f;
    public float camerazaxis = 0f;
    
    void Update()
    {
        Vector3 pos = player.transform.position;
       
        pos.z += camerazaxis;
        pos.y += camerayaxis;
        pos.x += cameraxaxis;
        
        transform.position = pos;
    }
}


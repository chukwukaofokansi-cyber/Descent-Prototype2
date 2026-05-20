using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerRespawn : MonoBehaviour
{


    private Vector3 Therespawnpoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Therespawnpoint = transform.position;

        Debug.Log("Start checkpoint " + Therespawnpoint);
    }

    // Update is called once per frame
    public void UpdateCheckPoint(Vector3 CheckPointNew)
    {
        Therespawnpoint = CheckPointNew;

        Debug.Log("new checkPoint set: " + Therespawnpoint);
    }

    public void RespanwNew()
    {
        transform.position = Therespawnpoint;  

        Debug.Log("Respawning AT: " + Therespawnpoint);
    }
}

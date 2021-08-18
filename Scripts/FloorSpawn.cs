using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawn : MonoBehaviour
{
    public GameObject lastFloor;
    void Start()
    { 
        for(int i=0; i<20; i++)
        {
            CreateFloor();
        } 
    }
    public void CreateFloor()
    {
        Vector3 FloorDirection;
        if(Random.Range(0,2)==0)
        {
            FloorDirection=Vector3.left;
        }
        else
        {
            FloorDirection=Vector3.forward;
        }

        lastFloor= Instantiate(lastFloor,lastFloor.transform.position+FloorDirection,lastFloor.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ballLoc;
    Vector3 space;
    void Start()
    {
        space=transform.position-ballLoc.transform.position;
    }

  
    void Update()
    {
        if(BallMove.IsFinish==false)
        transform.position=ballLoc.transform.position+space;
    }
}

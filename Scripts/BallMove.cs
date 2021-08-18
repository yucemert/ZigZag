using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public FloorSpawn FloorSpawnSc;
    Vector3 Direction;
    public float Speed;
    public static bool IsFinish;
    public float increaseSpeed;
    void Start()
    {
        Direction=Vector3.forward;
        IsFinish=false;
    }

    
    void Update()
    {
        if(transform.position.y<=0.5f)
        {
            IsFinish=true;
        }

        if(IsFinish==true)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(Direction.x==0)
            Direction=Vector3.left;
            else
            {
                Direction=Vector3.forward;
            }
            Speed+=increaseSpeed*Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 Move=Direction*Time.deltaTime*Speed;
        transform.position+=Move;
    }

    //Temas Bittiğinde
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag=="Floor")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            FloorSpawnSc.CreateFloor();
            StartCoroutine(DestroyFloor(collision.gameObject));
           
        }
    }
    //Zemin Sil
    IEnumerator DestroyFloor(GameObject destroyedFloor)
    {
        yield return new WaitForSeconds(3f);
        Destroy(destroyedFloor);
    }






}

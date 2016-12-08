using UnityEngine;
using System.Collections;

public class MissileFollower : MonoBehaviour
{
    public Transform plane;
    private Vector3 dir;
    public float speed = 3;
    
    private void Start()
    {
        if (plane == null)
        {
            plane = GameObject.Find("plane").transform;
        }
        dir = (plane.position - transform.position).normalized;
    }

    private void Update()
    {
        transform.position += dir * Time.deltaTime * speed;
    }
}


/*
    public Vector3 planeInitalPos;
    public Transform plane;

    float xVal;
    float yVal;

    Inside Start Func
        planeInitalPos = plane.position;
        float dirX = (
            (planeInitalPos.x - transform.position.x)
           / Mathf.Abs(planeInitalPos.x - transform.position.x)
           );
        float dirY = (
            (planeInitalPos.y - transform.position.y)
           / Mathf.Abs(planeInitalPos.y - transform.position.y)
           );

        xVal = dirX;
        yVal = dirY;
*/

using UnityEngine;
using System.Collections;

public class MissileCollisionChecker : MonoBehaviour
{
    public Transform plane;


	void Update ()
    {
        Collided();
    }


    private void Collided()
    {
        if (plane == null)
        {
            plane = GameObject.Find("plane").transform;
        }
        if ((plane.position - transform.position).magnitude < 0.5f)
        {
            Debug.Log("It is crashed");
            GetComponent<AudioSource>().Play();
            Time.timeScale = 0.0f;
            Destroy(plane.gameObject);
        }
    }





    private void JustForBackUps()
    {
        Vector3 planePosition = plane.position;
        Vector3 missilePosition = transform.position;

        float planeX = planePosition.x;
        float planeY = planePosition.y;

        float missileX = missilePosition.x;
        float missileY = missilePosition.y;

        float dist = Mathf.Sqrt(
            ((missileX - planeX) * (missileX - planeX))
           + ((missileY - planeY) * (missileY - planeY))
        );

        if (dist <= 0.5f)
        {
            Debug.Log("It is crashed");
            Destroy(plane.gameObject);
        }
    }
}



using UnityEngine;
using System.Collections;

public class MissileSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float interval = 3.0f;

    float destroyTime = 7.0f;

    void Update()
    {
        if (interval <= 0)
        {
            interval = 3;
            GameObject created = GameObject.Instantiate(prefab);
            created.transform.position = transform.position;
            GameObject.Destroy(created, destroyTime);
        }
        else
        {
            interval -= Time.deltaTime;
        }
    }
}
   

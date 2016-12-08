using UnityEngine;
using System.Collections;

public class MissileSpawner : MonoBehaviour
{
    public GameObject prefab;
    float interval = 3;

    void Update()
    {
        if (interval <= 0)
        {
            interval = 3;
            GameObject created = GameObject.Instantiate(prefab);
            created.transform.position = transform.position;
        }
        else
        {
            interval -= Time.deltaTime;
        }
    }
}
   

using UnityEngine;
using System.Collections;

/// <summary>
/// Plane에 관련 된 스크립트. 주로 이동을 담당한다.
/// </summary>
public class PlaneScript : MonoBehaviour
{
    public float speed = 3;
	
	void Update ()
    {
        UserMove();
    }

    public void SetSpeed(int _speed)
    {
        speed = _speed;
    }
    public float GetSpeed()
    {
        return speed;
    }


    private void UserMove()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W) == true)
            dir += Vector3.up;
        if (Input.GetKey(KeyCode.S) == true)
            dir += Vector3.down;
        if (Input.GetKey(KeyCode.A) == true)
            dir += Vector3.left;
        if (Input.GetKey(KeyCode.D) == true)
            dir += Vector3.right;

        dir.Normalize();
        transform.localPosition += dir * speed * Time.deltaTime;
    }

}

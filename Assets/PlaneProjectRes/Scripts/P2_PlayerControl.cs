using UnityEngine;
using System.Collections;

public class P2_PlayerControl : MonoBehaviour {

    public BoxCollider floor;

	void Update () {
        if (Input.GetMouseButtonUp(0) == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (floor.Raycast(ray, out hitInfo, 1000) == true)
            {
                Vector3 myPos = transform.position;
                Vector3 hitPos = hitInfo.point;

                myPos.y = 0;
                hitPos.y = 0;

                Vector3 dir = hitPos - myPos;
                GetComponent<Rigidbody>().AddForce(dir * 5.0f, ForceMode.Impulse);

            }
        }
	}
}

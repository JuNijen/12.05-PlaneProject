using UnityEngine;
using System.Collections;

public class P2_HoleControl : MonoBehaviour {

    public MeshRenderer[] walls;

    //float elaspedTime;

    //void Update()
    //{

    //}




    void OnTriggerEnter(Collider collider)
    {
        StartCoroutine(WallAnimation());
    }

    IEnumerator WallAnimation()
    {
        Color[] beforeColor = new Color[walls.Length];

        for (int i = 0; i < beforeColor.Length; i++)
        {
            beforeColor[i] = walls[i].material.color;
        }
        SetColor(new Color(1, 1, 1));
        yield return new WaitForSeconds(0.05f);
        SetColor(new Color(0, 0, 0));
        yield return new WaitForSeconds(0.05f);
        SetColor(new Color(0.5f, 0.5f, 0.5f));
        yield return new WaitForSeconds(0.05f);

        for (int i = 0; i < beforeColor.Length; i++)
        {
            walls[i].material.color = beforeColor[i];
        }

    }

    void SetColor(Color color)
    {
        for (int i = 0; i < walls.Length; i++)
            walls[i].material.color = color;
    }
}

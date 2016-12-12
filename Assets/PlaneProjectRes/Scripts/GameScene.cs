using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScene : MonoBehaviour {

    public string SceneName = "FirstScene";

    public GameObject plane;
    public GameObject restartBtn;

    public float elapsedTime;
    public Text label;

    void Start()
    {
        if (plane == null)
        {
            plane = GameObject.Find("plane");
        }
        restartBtn.SetActive(false);
    }

    void Update()
    {
        if (plane == null)
        {
            restartBtn.SetActive(true);
        }
        else
        {
            elapsedTime += Time.deltaTime;
            label.text = "Time score : " + ((int)elapsedTime).ToString();   
        }
    }


    public void SceneChange(string _sceneName)
    {
            Application.LoadLevel(1);
    }
}

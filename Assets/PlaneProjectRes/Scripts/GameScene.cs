using UnityEngine;
using System.Collections;

public class GameScene : MonoBehaviour {

    public GameObject plane;
    public string SceneName = "FirstScene";

    void OnGUI()
    {
        if (plane == null)
        {
            if (GUI.Button(new Rect(100, 100, 100, 100), "Restart?") == true)
            {
                SceneChange(SceneName);
            }
        }
    }

    void SceneChange(string _sceneName)
    {
            Application.LoadLevel(_sceneName);
    }
}

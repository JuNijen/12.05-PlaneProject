using UnityEngine;
using System.Collections;

public class TitleScene : MonoBehaviour
{
    public string SceneName = "FirstScene";

    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 50), "닷지");

        if (GUI.Button(new Rect(100, 125, 100, 50), "Start!") == true)
        {
            SceneChange(SceneName);
        }
    }

    void SceneChange(string _sceneName)
    {
        Application.LoadLevel(_sceneName);
    }
}
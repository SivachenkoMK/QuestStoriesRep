using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public void OpenScene(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

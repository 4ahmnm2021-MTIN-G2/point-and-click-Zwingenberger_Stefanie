using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScneLoader : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}

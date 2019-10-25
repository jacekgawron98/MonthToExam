using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStartButton : MonoBehaviour
{
    [SerializeField]
    private GameObject helpScreen;

    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ShowHelp()
    {
        helpScreen.SetActive(true);
    }
}

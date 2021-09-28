using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButttonAction : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

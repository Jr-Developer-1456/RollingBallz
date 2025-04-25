using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagement : MonoBehaviour
{
    public void StartButton(){
        SceneManager.LoadScene(1);
    }
    public void ExitButton(){
        Application.Quit();
    }
    public void RestartButton(){
        SceneManager.LoadScene(0);
    }
}

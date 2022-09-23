using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Task1()
    {
        SceneManager.LoadScene(1);
    }

    public void Taks2()
    {
        SceneManager.LoadScene(2);
    }

    public void Taks3()
    {
        SceneManager.LoadScene(3);
    }
}

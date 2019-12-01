using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public void screen1()
    {
        SceneManager.LoadScene("menu");
    }


    public void screen2()
    {
        SceneManager.LoadScene("intro");
    }

    public void screen3()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void screen4()
    {
        SceneManager.LoadScene("credits");
    }

    public void exitfn()
    {
        Application.Quit();//UnityEditor.EditorApplication.isPlaying = false;
    }
}

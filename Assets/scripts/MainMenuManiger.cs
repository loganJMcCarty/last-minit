using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuManiger : MonoBehaviour
{
    public GameObject menu;
    public GameObject htp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void hunt()
    {
        SceneManager.LoadScene(1);
    }

    public void Htp()
    {
        htp.SetActive(true);
        menu.SetActive(false);
    }

    public void GoBack()
    {
        htp.SetActive(false);
        menu.SetActive(true);
    }

    


    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

#else
                Application.Quit();
#endif
    }

}


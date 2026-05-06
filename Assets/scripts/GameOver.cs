using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject retry;


    public void Agian()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }

    private void OnEnable()
    {
        CarControl.OnPlayerDeath += EnableGameOverMenu;
        Debug.Log("ALL TESLAS MUST BURN!!!!!!");
    }

    private void OnDisable()
    {
        CarControl.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(retry);

    }
}


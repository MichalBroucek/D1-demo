using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 2.5f;
    bool gameHasEnded = false;

    //public GameObject completeLevelUI;

    //public void CompleteLevel()
    //{
    //    completeLevelUI.SetActive(true);
    //}

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        Debug.Log("Restart from GameManager ...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

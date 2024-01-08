using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    bool gameended = false;
    public float restartDelay =1f;
    public GameObject completeLevel;
    public void ComepliteLevel()
    {
        completeLevel.SetActive(true);
    }
    public void EndGame()
    {
        if (gameended == false)
        {
            gameended = true;
            Debug.Log("Game Over");
            Invoke("restart" ,restartDelay);
        }      
    }
   
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

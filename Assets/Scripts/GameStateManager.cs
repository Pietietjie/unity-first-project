using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public void EndRun()
    {
        FindObjectOfType<PlayerMovement>().enabled = false;
        FindObjectOfType<PlayerScore>().StopTimer();
        Debug.Log("Game Over");
        Invoke("Restart", 3f);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

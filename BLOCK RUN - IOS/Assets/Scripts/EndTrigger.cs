using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        movement.enabled = false;
        gameManager.CompleteLevel();

        Invoke("EndOfLevelSceneChange", 4f);
    }

    public void EndOfLevelSceneChange()
    {
        SceneManager.LoadScene(1);
    }
}

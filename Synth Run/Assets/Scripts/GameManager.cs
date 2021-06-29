using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    public GameObject score;

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public GameObject object1;
    public GameObject object2;
    public int sceneIndex;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        sceneIndex = scene.buildIndex;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SetHighScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        SetHighScore();
        Debug.Log("Level completed");
        completeLevelUI.SetActive(true);
        score.SetActive(false);
        if (PlayerPrefs.GetInt("levelReached") < levelToUnlock)
        {
             PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }

    }

    public void SetHighScore()
    {
        float distance = (object2.transform.position.z - object1.transform.position.z);
        float scorePercentage = 100f - (distance / 30f);

        if (sceneIndex == 2)    //CHECKS FOR LEVEL 0
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore0", 0))
            {
                PlayerPrefs.SetFloat("HighScore0", scorePercentage);
            }
        }
        if (sceneIndex == 3)    //CHECKS FOR LEVEL 1
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore1", 0))
            {
                PlayerPrefs.SetFloat("HighScore1", scorePercentage);
            }
        }
        if (sceneIndex == 4)    //CHECKS FOR LEVEL 2
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore2", 0))
            {
                PlayerPrefs.SetFloat("HighScore2", scorePercentage);
            }
        }
        if (sceneIndex == 5)    //CHECKS FOR LEVEL 3
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore3", 0))
            {
                PlayerPrefs.SetFloat("HighScore3", scorePercentage);
            }
        }
        if (sceneIndex == 6)    //CHECKS FOR LEVEL 4
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore4", 0))
            {
                PlayerPrefs.SetFloat("HighScore4", scorePercentage);
            }
        }
        if (sceneIndex == 7)    //CHECKS FOR LEVEL 5
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore5", 0))
            {
                PlayerPrefs.SetFloat("HighScore5", scorePercentage);
            }
        }
        if (sceneIndex == 8)    //CHECKS FOR LEVEL 6
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore6", 0))
            {
                PlayerPrefs.SetFloat("HighScore6", scorePercentage);
            }
        }
        if (sceneIndex == 9)    //CHECKS FOR LEVEL 7
        {
            if (scorePercentage > PlayerPrefs.GetFloat("HighScore7", 0))
            {
                PlayerPrefs.SetFloat("HighScore7", scorePercentage);
            }
        }
    }
}

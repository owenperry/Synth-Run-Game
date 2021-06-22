using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TMP_Text scoreTextTMP;
    public TMP_Text highScoreTMP;

    public float distance = 0;
    public string scoreCount;
    public string percentage = "%";
    public int sceneIndex;

    public GameObject object1;
    public GameObject object2;

    private void Start()
    {
        highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore", 0).ToString("0") + "%");
        Scene scene = SceneManager.GetActiveScene();
        sceneIndex = scene.buildIndex;
    }

    void Update()
    {
        float distance = (object2.transform.position.z - object1.transform.position.z);

        if (distance >= 1)
        {
            scoreCount = (100 - (distance / 30)).ToString("0");
            scoreTextTMP.text = scoreCount + percentage;
        }

        if (sceneIndex == 2)    //CHECKS FOR LEVEL 0
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore0", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore0", 0))
            {
                PlayerPrefs.SetFloat("HighScore0", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore0", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 3)    //CHECKS FOR LEVEL 1
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore1", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore1", 0))
            {
                PlayerPrefs.SetFloat("HighScore1", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore1", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 4)    //CHECKS FOR LEVEL 2
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore2", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore2", 0))
            {
                PlayerPrefs.SetFloat("HighScore2", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore2", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 5)    //CHECKS FOR LEVEL 3
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore3", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore3", 0))
            {
                PlayerPrefs.SetFloat("HighScore3", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore3", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 6)    //CHECKS FOR LEVEL 4
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore4", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore4", 0))
            {
                PlayerPrefs.SetFloat("HighScore4", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore4", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 7)    //CHECKS FOR LEVEL 5
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore5", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore5", 0))
            {
                PlayerPrefs.SetFloat("HighScore5", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore5", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 8)    //CHECKS FOR LEVEL 6
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore6", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore6", 0))
            {
                PlayerPrefs.SetFloat("HighScore6", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore6", 0).ToString("0") + "%");
            }
        }
        if (sceneIndex == 9)    //CHECKS FOR LEVEL 7
        {
            highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore7", 0).ToString("0") + "%");
            if ((100 - (distance / 30)) > PlayerPrefs.GetFloat("HighScore7", 0))
            {
                PlayerPrefs.SetFloat("HighScore7", 100 - (distance / 30));
                highScoreTMP.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore7", 0).ToString("0") + "%");
            }
        }
    }

}

using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{

    public Button[] levelButtons;
    public GameObject[] lockIcons;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 2);

        for(int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
                lockIcons[i].GetComponent<Image>().enabled = true;
            } else { 
                lockIcons[i].GetComponent<Image>().enabled = false;      
            }

        }
    }

    public void btn_change_scene()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<GameManager>().SetHighScore();
    }

    public void titleScene()
    {
        SceneManager.LoadScene(0);
    }

    public void levelTutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void level1()
    {
        SceneManager.LoadScene(3);
    }

    public void level2()
    {
        SceneManager.LoadScene(4);
    }

    public void level3()
    {
        SceneManager.LoadScene(5);
    }

    public void level4()
    {
        SceneManager.LoadScene(6);
    }

    public void level5()
    {
        SceneManager.LoadScene(7);
    }

    public void level6()
    {
        SceneManager.LoadScene(8);
    }

    public void level7()
    {
        SceneManager.LoadScene(9);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}

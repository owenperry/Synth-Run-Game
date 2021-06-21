using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicConfinue : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (i == 0)
        {
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("IF STATEMENT");
            i++;
        }

        /*else
        {
            Destroy(this.gameObject);
            Debug.Log("ELSE CUNT");
        }*/
    }

    void update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "LevelSelector") //|| scene.name != "Title")
        {
            Destroy(this.gameObject);
        }
    }
}
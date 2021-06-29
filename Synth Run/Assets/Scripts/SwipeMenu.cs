using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwipeMenu : MonoBehaviour
{
    public GameObject scrollbar;
    private float scroll_pos = 0;
    float[] pos;

    public TMP_Text highScoreTMP0,
                    highScoreTMP1,
                    highScoreTMP2,
                    highScoreTMP3,
                    highScoreTMP4,
                    highScoreTMP5,
                    highScoreTMP6,
                    highScoreTMP7;

    // Start is called before the first frame update
    void Start()
    {
        highScoreTMP0.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore0", 0).ToString("0") + "%"); //SETS LEVEL 0 HGIH SCORE
        highScoreTMP1.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore1", 0).ToString("0") + "%"); //SETS LEVEL 1 HGIH SCORE
        highScoreTMP2.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore2", 0).ToString("0") + "%"); //SETS LEVEL 2 HGIH SCORE
        highScoreTMP3.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore3", 0).ToString("0") + "%"); //SETS LEVEL 3 HGIH SCORE
        highScoreTMP4.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore4", 0).ToString("0") + "%"); //SETS LEVEL 4 HGIH SCORE
        highScoreTMP5.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore5", 0).ToString("0") + "%"); //SETS LEVEL 5 HGIH SCORE
        highScoreTMP6.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore6", 0).ToString("0") + "%"); //SETS LEVEL 6 HGIH SCORE
        highScoreTMP7.text = ("High Score - " + PlayerPrefs.GetFloat("HighScore7", 0).ToString("0") + "%"); //SETS LEVEL 7 HGIH SCORE
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }


        //for (int i = 0; i < pos.Length; i++)
        //{
        //    if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
        //    {
        //        transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.3f, 1.3f), 0.1f);
        //        for (int j = 0; j < pos.Length; j++)
        //        {
        //            if (j != i)
        //            {
        //                transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
        //            }
        //        }
        //    }
        //}

    }
}
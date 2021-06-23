using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TMP_Text scoreTextTMP;

    public float distance = 0;
    public string scoreCount;
    public string percentage = "%";

    public GameObject object1;
    public GameObject object2;

    void Update()
    {
        float distance = (object2.transform.position.z - object1.transform.position.z);
        if (distance >= 1)
        {
            scoreCount = (100 - (distance / 30)).ToString("0");
            scoreTextTMP.text = scoreCount + percentage;
        }
    }
}

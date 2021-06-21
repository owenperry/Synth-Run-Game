using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreTextTMP;

    public float distance = 0;
    public string scoreCount;
    public string percentage = "%";

    public GameObject object1;
    public GameObject object2;

    // Update is called once per frame
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

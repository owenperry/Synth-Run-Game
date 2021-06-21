using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontKillTheMusic : MonoBehaviour
{

    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        while(i < 1)
        {
            DontDestroyOnLoad(this.gameObject);
            i++;
        }
    }
}

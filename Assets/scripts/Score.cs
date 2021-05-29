using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    //sets score back to 0 on restart
    void Start()
    {
        score = 0;
    }
    // makes TMPro display current score
    private void Update()
    {       
        GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
    }

}

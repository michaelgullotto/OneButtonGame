using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // adds score on collison with empty object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float speed;
    // moves spawned pipes to the left so that screen dosent have to move
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

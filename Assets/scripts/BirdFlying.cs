using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdFlying : MonoBehaviour
{
    public GameManger gameManger;
    public float velocity = 1;
    private Rigidbody2D rb;
    // tells player to get rigid body component on start which controls gravity physics
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // player control lets player use lmb or space to jump
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    // tells game to call GameOver function on collision
    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameManger.GameOver();
    }
}

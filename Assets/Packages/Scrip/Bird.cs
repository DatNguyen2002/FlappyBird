using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public LogicScrip logic;
    public float antiGravity;
    public bool birdIsALive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScrip>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * antiGravity;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsALive = false;
    }
}

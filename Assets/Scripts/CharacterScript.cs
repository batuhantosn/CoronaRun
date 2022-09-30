using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterScript : MonoBehaviour
{
    private Rigidbody2D playerRB;

    public bool gameOver = false;
    public float force;
    private int score = 0;
    public bool isOnGround = true;
    private PointText PointText;
    public GameOverScreen GameOverScreen;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody2D>();
        PointText = GameObject.FindWithTag("Time").GetComponent<PointText>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isOnGround == true)
        {
            playerRB.AddForce(Vector2.up * force , ForceMode2D.Impulse);
            isOnGround = false;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vaccine"))
        {
            Destroy(collision.gameObject);
            PointText.currentPoint += 1;
            score += 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;  
            
        }
        
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOver = true;
            Destroy(GameObject.FindWithTag("Corona"));
            Destroy(GameObject.FindWithTag("Enemy"));
            anim.SetBool("isDead", true);
            Invoke("GameOverDelay", 0.8f);
            

        }
        
        
    } 
    void GameOverDelay()
    {
        GameOverScreen.Setup(score);
    }

}

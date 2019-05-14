using System.Collections;
using UnityEngine;


public class PelaajanLiikkuminen : MonoBehaviour
{
    private Rigidbody2D rb;
    bool isGrounded;
    private float runSpeed = 5f;
    private float voima = 25000f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {    
        float move = Input.GetAxis("Horizontal");  

        rb.velocity = new Vector2(runSpeed * move, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * this.voima);
            this.isGrounded = false;

            GameObject.Find("Hyppyääni").GetComponents<AudioSource>()[0].Play();
        }
    }

    void OnCollisionEnter2D(Collision2D Laatikko)
    {      
            this.isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D Laatikko)
    {
        this.isGrounded = false;
    }

}

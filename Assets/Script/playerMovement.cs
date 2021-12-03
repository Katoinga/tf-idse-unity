using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed = 2f;
    public float maxSpeed = 10f;
    public GameObject canvas;
    public Camera main;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            GetComponent<Animator>().SetBool("arriba", true);
            transform.Translate(0,0.0025f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            GetComponent<Animator>().SetBool("abajo", true);
            transform.Translate(0,-0.0025f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {

            GetComponent<Animator>().SetBool("izquierda", true);
            transform.Translate(-0.0025f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<Animator>().SetBool("derecha", true);
            transform.Translate(0.0025f, 0, 0);
        }
        if ( Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("arriba", false);
            GetComponent<Animator>().SetBool("abajo", false);
            GetComponent<Animator>().SetBool("izquierda", false);
            GetComponent<Animator>().SetBool("derecha", false);

        }




        /* void FixedUpdate()
         {
             float h = Input.GetAxis("Horizontal");
             rb2d.AddForce(Vector2.right * speed * h);
             if (rb2d.velocity.x > maxSpeed)
             {
                 rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
             }
             if (rb2d.velocity.x < -maxSpeed)
             {
                 rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
             }
         }*/

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            GetComponent<Animator>().SetBool("muerte", true);
            canvas.SetActive(true);
            main.GetComponent<AudioSource>().mute = false;

        }
    }
}

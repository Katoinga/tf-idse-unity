using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovePlayer : MonoBehaviour
{

    public JoystickScript movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
            if (movementJoystick.joystickVec.y * playerSpeed > 0)
            {
                GetComponent<Animator>().SetBool("arriba", true);
            }
            if (movementJoystick.joystickVec.y * playerSpeed < 0)
            {
                GetComponent<Animator>().SetBool("abajo", true);
            }
            if (movementJoystick.joystickVec.x * playerSpeed > 0)
            {
                GetComponent<Animator>().SetBool("derecha", true);
            }
            if (movementJoystick.joystickVec.x * playerSpeed < 0)
            {
                GetComponent<Animator>().SetBool("izquierda", true);
            }
        }
        else
        {
            GetComponent<Animator>().SetBool("arriba", false);
            GetComponent<Animator>().SetBool("abajo", false);
            GetComponent<Animator>().SetBool("izquierda", false);
            GetComponent<Animator>().SetBool("derecha", false);
            rb.velocity = Vector2.zero;
        }
    }
}
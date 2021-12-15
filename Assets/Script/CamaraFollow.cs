using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
    
{
    public GameObject jugador;
    public Vector2 min;
    public Vector2 max;
    public float suavizado;
    Vector2 velocity;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x,jugador.transform.position.x, ref velocity.x, suavizado);
        float posY = Mathf.SmoothDamp(transform.position.y, jugador.transform.position.y, ref velocity.y, suavizado);

        transform.position = new Vector3(Mathf.Clamp(posX, min.x, max.x), Mathf.Clamp(posY, min.y, max.y),transform.position.z);
    }

}

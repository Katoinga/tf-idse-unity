using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private GameObject buttnCajamarca,bttnLoreto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cajamarca"))
        {
            buttnCajamarca.SetActive(true);
        }
        if (collision.CompareTag("Loreto"))
        {
            bttnLoreto.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Cajamarca"))
        {
            buttnCajamarca.SetActive(false);
        }
        if (collision.CompareTag("Loreto"))
        {
            bttnLoreto.SetActive(false);
        }
    }
}

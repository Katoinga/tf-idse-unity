using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject cajamarca;
    public GameObject maincanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowDepartamento()
    {
        cajamarca.SetActive(true);
        maincanvas.SetActive(false);
    }
    public void OcultarDepartamento()
    {
        cajamarca.SetActive(false);
        maincanvas.SetActive(true);
    }
    

}

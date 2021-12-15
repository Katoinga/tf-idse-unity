using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject depar;
    public GameObject maincanvas;
    public GameObject imbbg1,imbg2;

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
        depar.SetActive(true);
        maincanvas.SetActive(false);
        imbbg1.SetActive(true);
    }
    public void OcultarDepartamento()
    {
        depar.SetActive(false);
        imbbg1.SetActive(false);
        imbg2.SetActive(false);

        maincanvas.SetActive(true);
    }
    

}

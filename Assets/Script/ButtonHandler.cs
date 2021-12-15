using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject depar;
    public GameObject maincanvas;
    public GameObject imbbg1,imbg2,bg3, bg4,bg5,bg6,bg7,bg8,bg9,bg10
        ,bg11,bg12,bg13,bg14,bg15,bg16,bg17,bg18,bg19,bg20,bg21,bg22,bg23,bg24,bg25;

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
        maincanvas.SetActive(true);


        depar.SetActive(false);
        imbbg1.SetActive(false);
        imbg2.SetActive(false);
        bg3.SetActive(false);
        bg4.SetActive(false);
        bg5.SetActive(false);
        bg6.SetActive(false);
        bg7.SetActive(false);
        bg8.SetActive(false);
        bg9.SetActive(false);
        bg10.SetActive(false);
        bg11.SetActive(false);
        bg12.SetActive(false);
        bg13.SetActive(false);
        bg14.SetActive(false);
        bg15.SetActive(false);
        bg16.SetActive(false);
        bg17.SetActive(false);
        bg18.SetActive(false);
        bg19.SetActive(false);
        bg20.SetActive(false);
        bg21.SetActive(false);
        bg22.SetActive(false);
        bg23.SetActive(false);
        bg24.SetActive(false);
        bg25.SetActive(false);


    }


}

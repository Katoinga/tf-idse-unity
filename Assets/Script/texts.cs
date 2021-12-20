using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texts : MonoBehaviour
{
    public GameObject text1, text2, maincanva,lent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showNext()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        lent.SetActive(false);
    }
    public void endDiag()
    {
        text1.SetActive(false);
        maincanva.SetActive(true);
    }
    public void showlent()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        lent.SetActive(true);
    }
}

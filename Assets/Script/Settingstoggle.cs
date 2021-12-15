using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingstoggle : MonoBehaviour
{
    public GameObject settingscanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showSett()
    {
        settingscanvas.SetActive(true);
    }
    public void hideSett()
    {
        settingscanvas.SetActive(false);
    }
}

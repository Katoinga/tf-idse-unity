using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour
{
    public GameObject maincanva,startcanva;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGAme()
    {
        maincanva.SetActive(true);
        startcanva.SetActive(false);
    }
    public void quitGAme()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.ExitPlaymode();
        #else
                    Application.Quit();
        #endif
    }
}

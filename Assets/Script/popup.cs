using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject canv;
    public bool flag = false;
    // Start is called before the first frame update
    public void pop()
    {
        if (flag == false)
        {
            flag = true;
            canv.SetActive(true);
        }
        else if (flag== true)
        {
            flag = false;
            canv.SetActive(false);
        }
    }
    public void quitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }


}

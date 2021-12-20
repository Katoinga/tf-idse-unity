using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public textos texts;
    private void OnMouseDown()
    {
        FindObjectOfType<ControlDialog>().ActivarCartel(texts);
    }
}

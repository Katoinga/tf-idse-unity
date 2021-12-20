using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialog : MonoBehaviour
{
    private Animator anim;
    private Queue<string> colaDialog;
    textos texts;
    [SerializeField] TextMeshProUGUI textoPantalla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarCartel(textos textobj)
    {
        anim.SetBool("Cartel", true);
        texts = textobj;

    }
    public void ActivaTexto()
    {
        colaDialog.Clear();
        foreach (string textoguardar in texts.arrayTextos)
        {
            colaDialog.Enqueue(textoguardar);
        }
        SiguienteFrase();
    }
    public void SiguienteFrase()
    {
        if(colaDialog.Count == 0)
        {
            CierraCartel();
            return;
        }
        string fraseActual = colaDialog.Dequeue();
        textoPantalla.text = fraseActual;
    }
    void CierraCartel()
    {
        anim.SetBool("Cartel", false);
    }
    IEnumerator MostrarChars(string textoMostrar)
    {
        textoPantalla.text = "";
        foreach (char caracter in textoMostrar.ToCharArray())
        {
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.02f);
        }
    }

}

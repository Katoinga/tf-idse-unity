using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private GameObject
        Amazonas, Ancash, Apurimac, 
        Arequipa, Ayacucho, Cajamarca, 
        Callao, Cusco, Huancavelica, 
        Huanuco, Ica, Junin, LaLibertad, 
        Lambayeque, Lima, Loreto, 
        MadredeDios, Moquegua, Pasco, Piura, 
        Puno, SanMartin, Tacna, Tumbes,
        Ucayali;
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
        
        if (collision.CompareTag("Amazonas"))
        {
            Amazonas.SetActive(true);
        }
        if (collision.CompareTag("Ancash"))
        {
            Ancash.SetActive(true);
        }
        if (collision.CompareTag("Apurimac"))
        {
            Apurimac.SetActive(true);
        }
        if (collision.CompareTag("Arequipa"))
        {
            Arequipa.SetActive(true);
        }
        if (collision.CompareTag("Ayacucho"))
        {
            Ayacucho.SetActive(true);
        }
        if (collision.CompareTag("Cajamarca"))
        {
            Cajamarca.SetActive(true);
        }
        if (collision.CompareTag("Cusco"))
        {
            Cusco.SetActive(true);
        }
        if (collision.CompareTag("Huancavelica"))
        {
            Huancavelica.SetActive(true);
        }
        if (collision.CompareTag("Huanuco"))
        {
            Huanuco.SetActive(true);
        }
        if (collision.CompareTag("Ica"))
        {
            Ica.SetActive(true);
        }
        if (collision.CompareTag("Junin"))
        {
            Junin.SetActive(true);
        }
        if (collision.CompareTag("LaLibertad"))
        {
            LaLibertad.SetActive(true);
        }
        if (collision.CompareTag("Lambayeque"))
        {
            Lambayeque.SetActive(true);
        }
        if (collision.CompareTag("Lima"))
        {
            Lima.SetActive(true);
        }
        if (collision.CompareTag("Loreto"))
        {
            Loreto.SetActive(true);
        }
        if (collision.CompareTag("MadredeDios"))
        {
            MadredeDios.SetActive(true);
        }
        if (collision.CompareTag("Moquegua"))
        {
            Moquegua.SetActive(true);
        }
        if (collision.CompareTag("Pasco"))
        {
            Pasco.SetActive(true);
        }
        if (collision.CompareTag("Piura"))
        {
            Piura.SetActive(true);
        }
        if (collision.CompareTag("Puno"))
        {
            Puno.SetActive(true);
        }
        if (collision.CompareTag("SanMartin"))
        {
            SanMartin.SetActive(true);
        }
        if (collision.CompareTag("Tacna"))
        {
            Tacna.SetActive(true);
        }
        if (collision.CompareTag("Tumbes"))
        {
            Tumbes.SetActive(true);
        }
        if (collision.CompareTag("Ucayali"))
        {
            Ucayali.SetActive(true);
        }
        if (collision.CompareTag("Callao"))
        {
            Callao.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Amazonas"))
        {
            Amazonas.SetActive(false);
        }
        if (collision.CompareTag("Ancash"))
        {
            Ancash.SetActive(false);
        }
        if (collision.CompareTag("Apurimac"))
        {
            Apurimac.SetActive(false);
        }
        if (collision.CompareTag("Arequipa"))
        {
            Arequipa.SetActive(false);
        }
        if (collision.CompareTag("Ayacucho"))
        {
            Ayacucho.SetActive(false);
        }
        if (collision.CompareTag("Cajamarca"))
        {
            Cajamarca.SetActive(false);
        }
        if (collision.CompareTag("Cusco"))
        {
            Cusco.SetActive(false);
        }
        if (collision.CompareTag("Huancavelica"))
        {
            Huancavelica.SetActive(false);
        }
        if (collision.CompareTag("Huanuco"))
        {
            Huanuco.SetActive(false);
        }
        if (collision.CompareTag("Ica"))
        {
            Ica.SetActive(false);
        }
        if (collision.CompareTag("Junin"))
        {
            Junin.SetActive(false);
        }
        if (collision.CompareTag("LaLibertad"))
        {
            LaLibertad.SetActive(false);
        }
        if (collision.CompareTag("Lambayeque"))
        {
            Lambayeque.SetActive(false);
        }
        if (collision.CompareTag("Lima"))
        {
            Lima.SetActive(false);
        }
        if (collision.CompareTag("Loreto"))
        {
            Loreto.SetActive(false);
        }
        if (collision.CompareTag("MadredeDios"))
        {
            MadredeDios.SetActive(false);
        }
        if (collision.CompareTag("Moquegua"))
        {
            Moquegua.SetActive(false);
        }
        if (collision.CompareTag("Pasco"))
        {
            Pasco.SetActive(false);
        }
        if (collision.CompareTag("Piura"))
        {
            Piura.SetActive(false);
        }
        if (collision.CompareTag("Puno"))
        {
            Puno.SetActive(false);
        }
        if (collision.CompareTag("SanMartin"))
        {
            SanMartin.SetActive(false);
        }
        if (collision.CompareTag("Tacna"))
        {
            Tacna.SetActive(false);
        }
        if (collision.CompareTag("Tumbes"))
        {
            Tumbes.SetActive(false);
        }
        if (collision.CompareTag("Ucayali"))
        {
            Ucayali.SetActive(false);
        }
        if (collision.CompareTag("Callao"))
        {
            Callao.SetActive(false);
        }
    }
}

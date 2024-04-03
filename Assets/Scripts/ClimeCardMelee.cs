using UnityEngine;
using TMPro;
using System;
using JetBrains.Annotations;

public class Clima : MonoBehaviour
{
    public GameObject ZonaMelee;
    public GameObject padreObjeto;
    public GameObject hijoObjeto;

    public string sumaTextoTag = "SumaTexto";
    
    public void Update()
    {
        if (hijoObjeto.transform.IsChildOf(padreObjeto.transform))
        {
            Debug.Log(hijoObjeto.name + " es hijo de " + padreObjeto.name);
            TMP_Text sumaTexto = GameObject.FindGameObjectWithTag(sumaTextoTag)?.GetComponent<TMP_Text>();
            int nHijos = ZonaMelee.transform.childCount;

            int valorResta = nHijos * 2;


            int sumaActual = int.Parse(sumaTexto.text);
            sumaActual -= valorResta;
            sumaTexto.text = sumaActual.ToString();


        }
        else
        {
            Debug.Log(hijoObjeto.name + " no es hijo de " + padreObjeto.name);
        }
    


}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ZonaClima"))
        {
            //bool inZone = true;     
            GameObject[] zonasMelee = GameObject.FindGameObjectsWithTag("MeleeZone");

           
            foreach (GameObject zonaMelee in zonasMelee)
            {
                DisplayCard[] displayCards = zonaMelee.GetComponentsInChildren<DisplayCard>();
                foreach (DisplayCard displayCard in displayCards)
                {
                    
                    displayCard.power -= 2;
                }
            }

            
          
            
        }
    }
}

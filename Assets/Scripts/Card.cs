using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int power;
    public string cardDescription;
    public Sprite spriteImage;
    public string type;
    public enum Tipo { Melee, Distancia, Asedio }

    public string Nombre { get; set; }
    public Tipo TipoDeAtaque { get; set; }

    public int valor;

    
    public TMP_Text textoPuntaje;

    
    public void ConfigurarValor(int nuevoValor)
    {
        valor = nuevoValor;
    }



    public Card()
    {
    }
    public Card(int Id, string CardName, int Power, string CardDescription, Sprite SpriteImage, string Type, Tipo tipoDeAtaque)
    {
        id = Id;
        cardName = CardName;
        power = Power;
        cardDescription = CardDescription;
        spriteImage = SpriteImage;
        type = Type;
        TipoDeAtaque = tipoDeAtaque;

    }


}

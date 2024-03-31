using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta
{
    public enum Tipo { Melee, Distancia, Asedio }

    public string Nombre { get; set; }
    public Tipo TipoDeAtaque { get; set; }
    public int PoderDeAtaque { get; set; }

    // Constructor
    public Carta(string nombre, Tipo tipoDeAtaque, int poderDeAtaque)
    {
        Nombre = nombre;
        TipoDeAtaque = tipoDeAtaque;
        PoderDeAtaque = poderDeAtaque;
    }

    // M�todo para mostrar informaci�n de la carta
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Tipo de Ataque: {TipoDeAtaque}, Poder de Ataque: {PoderDeAtaque}");
    }
}


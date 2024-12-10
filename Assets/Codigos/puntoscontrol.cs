using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntoscontrol : MonoBehaviour
{
    public float puntitos = 0;
    Text texito;
    private void Awake()
    {
        texito = GetComponent<Text>();
    }
    public void maspuntos(float puntos)
    {
        puntitos = puntitos + puntos;
        texito.text = "PUNTOS: " + puntitos;
    }
    private void Start()
    {
        maspuntos(puntitos);
    }
}

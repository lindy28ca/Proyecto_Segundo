using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimepoControler : MonoBehaviour
{
    Text textito;
    public cambiarescena Esena;
    float tiempo = 120;
    float Minutos=0;
    float Segundos = 0;
    private void Awake()
    {
        textito = GetComponent<Text>();
    }
    private void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            Esena.escenas("perdiste");
        }
        MostrarTiempo(tiempo);
    }

    private void MostrarTiempo(float tiempoRestante)
    {
        Minutos = Mathf.Floor(tiempoRestante / 60);
        Segundos = Mathf.Floor(tiempoRestante % 60);
        textito.text = Minutos+":"+Segundos;
    }
}

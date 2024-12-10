using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class gamemanagercontrol : MonoBehaviour
{
    public puntoscontrol puntoscontrol;
    public AudioSource audioSource;
    public cambiarescena esena;
    public float PuntosFinales;
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (PuntosFinales <= puntoscontrol.puntitos)
        {
            esena.escenas("Ganaste");
        }
    }
    public void Aumentar(float puntitos)
    {
        puntoscontrol.maspuntos(puntitos);
    }
    public void Pausar()
    {
        Time.timeScale = 0;
    }
    public void Continuar()
    {
        Time.timeScale = 1;
    } 
    public void Mute(Image image)
    {
        if (audioSource.mute == true)
        {
            image.color = Color.white;
            audioSource.mute = false;
        }
        else
        {
            image.color = Color.red;
            audioSource.mute = true;
        }
    }

}

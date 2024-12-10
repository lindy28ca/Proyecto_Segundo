using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    public float puntos;
    public float Puntos { get { return puntos; } set { puntos = value; } }
    public gamemanagercontrol control;
    public static Frutas operator +(Frutas a,Sandia b)
    {
        a.Puntos = a.Puntos + 10;
        return a;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            control.Aumentar(Puntos);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.GetComponent<Sandia>())
        {
            Sandia otraFruta = collision.gameObject.GetComponent<Sandia>();
            Frutas resultado = this + otraFruta;
            this.Puntos = resultado.puntos;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandia : Movimientos
{
    public GameObject objetivo;
    public gamemanagercontrol control;
    public float Velocidad;
    public float puntos;
    public float Puntos { get { return puntos; } set { puntos = value; } }

    private void Start()
    {
        SetObjetive(objetivo);
    }

    private void Update()
    {
        Mover(Velocidad);
    }

    protected override void Mover(float Velocidad)
    {
        base.Mover(Velocidad);
    }

    protected override void SetObjetive(GameObject NewObjetivo)
    {
        base.SetObjetive(NewObjetivo);
    }
    public void LLenar(GameObject NewObjetivo)
    {
        SetObjetive (NewObjetivo);
    }
    public static Sandia operator +(Sandia a, Frutas b)
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
        if (collision.gameObject.GetComponent<Frutas>())
        {
            Frutas otraFruta = collision.gameObject.GetComponent<Frutas>();
            Sandia resultado = this + otraFruta;
            this.Puntos = resultado.puntos;
        }
    }
}

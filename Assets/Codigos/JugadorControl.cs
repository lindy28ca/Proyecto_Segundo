using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorControl : MonoBehaviour
{
    Rigidbody2D helado;
    public float velocidad;
    float horizontal;
    float vertical;
    public GameObject IceDestroyer;
    public int Directionx;
    public int Directiony;
    private void Awake()
    {
        helado = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (vertical == 0)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            if (horizontal > 0)
            {
                Directionx = 1;
                Directiony = 0;
            }
            else if (horizontal < 0)
            {
                Directionx = -1;
                Directiony = 0;
            }
        }
        if (horizontal == 0)
        {
            vertical = Input.GetAxisRaw("Vertical");
            if (vertical > 0)
            {
                Directiony = 1;
                Directionx = 0;
            }
            else if (vertical < 0)
            {
                Directiony = -1;
                Directionx = 0;
            }
            

        }
        IceDestroyer.transform.localPosition = new Vector2(2f * Directionx, 2f * Directiony);
    }
    private void FixedUpdate()
    {
        helado.velocity=new Vector2(horizontal*velocidad,vertical*velocidad);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IceDestroyerControl : MonoBehaviour
{
    public GameObject IceCube;
    public GameObject CrearIce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IceCube != null)
            {
                Destroy(IceCube);
            }
            else
            {
                Instantiate(CrearIce, transform.position, transform.rotation);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "IceCube")
        {
            IceCube = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "IceCube")
        {
            IceCube = null;
        }
    }
}

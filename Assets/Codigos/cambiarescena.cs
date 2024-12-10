using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarescena : MonoBehaviour
{

    public void escenas(string control)
    {
        SceneManager.LoadScene(control);
    }
}

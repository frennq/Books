using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string nombreEscena;

    public void CambioEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Exit(){
        Application.Quit();
    }
}

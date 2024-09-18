using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menudeinicio : MonoBehaviour
{
  public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }
    public void Salir()
    {
        Debug.Log("Salir..");
        Application.Quit();
    }
     public void regreso()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
     }
public void comoJugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Jugar2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }
    public void rsegreso()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
     }
}
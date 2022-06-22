using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Carga la escena

public class MenuInicio : MonoBehaviour
{

    //Metodo para iniciar el juego al pulsar Iniciar
    public void Iniciar(){
        Debug.Log("Juego Iniciado"); //Por consola
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Carga la siguiente escena que tenga cargada
    }

    public void Salir(){
        //Verlo por consola ya que al estar en Unity no lo detecta
        Debug.Log("Salir");
        //Parara la aplicacion al ejecutarse desde fuera de unity
        Application.Quit();
    }   
  
}

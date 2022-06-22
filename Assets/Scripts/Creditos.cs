using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Un trigger que se ejecuta cuando se pulsa el boton Salir

public class Creditos : MonoBehaviour
{
    
    //Metodo que se ejecuta al pulsar el boton Salir
    //Public porque tiene que aparecer en la jerarquia para la configuracion del boton
    public void Salir(){
        //Parara la aplicacion
        Application.Quit();
        //Verlo por consola ya que al estar en Unity no lo detecta 
        Debug.Log("Salir");
    }
}

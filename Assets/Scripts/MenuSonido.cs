using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Obligatorio al utilizar elementos de la interfaz de usuario

[RequireComponent(typeof(Toggle))] //El componente requerido se agrega automáticamente al GameObject necesario para pulsar el boton sonido
public class MenuSonido : MonoBehaviour
{
    Toggle sonido; //casilla de verificación que le permite al usuario cambiar una opción a prendido o apagado
  
    void Start()
    {
        sonido = GetComponent<Toggle>();
        if (AudioListener.volume == 0) //Si el AudioListener.volume es igual a 0
        {
            sonido.isOn = false; //isOn es un conmutador que devuelve desactivado, No habra sonido
        }
    }

    public void CambiaValor(bool audioDentro){ //declarado bool para saber el estado del sonido en true o false
        if (audioDentro) //Si audio
        {
            AudioListener.volume = 1; //Audio estara activado al ser igual a 1
        }
        else //Sino
        {
            AudioListener.volume = 0; //Audio estara desactivado al ser igual a 0
        }
    }
}

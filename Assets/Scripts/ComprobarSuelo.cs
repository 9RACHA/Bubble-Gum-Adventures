using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour
{
    public static bool tocaSuelo; //De tipo static para que otros scripts tengan acceso a esta variable

    //eventos de activación solo se envían si uno de los Colliders también tiene un Rigidbody2D adjunto
    private void OnTriggerEnter2D(Collider2D colision) //Cuando BoxCollider2D esta marcado con Is Trigger entra dentro de una geometria
    {
        tocaSuelo = true;   //tocaSuelo sera igual a verdadero
    }
    
    //eventos de activación se enviarán a MonoBehaviours deshabilitados, para permitir la habilitación de comportamientos en respuesta a colisiones
    private void OnTriggerExit2D(Collider2D colision) //Cuando no esta en contacto con el suelo
    {
        tocaSuelo = false; //tocaSuelo sera igual a falso
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaceDaño : MonoBehaviour 
{
    
    //Cuando entra dentro del objeto hace daño
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.transform.CompareTag("Player")) //si colision hace contacto con el tag player
        {
            Debug.Log("Jugador Dañado"); //Se refleja por consola que el jugador ha sido golpeado
    
            colision.transform.GetComponent<JugadorRespawn>().JugadorGolpeado(); //Vuelve al principio del juego o al punto de respawn
        }
    }
}

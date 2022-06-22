using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{ 
    //metodo que se utiza cuando cuando un colisionador entrante hace contacto con el colisionador de este objeto
    private void OnCollisionEnter2D(Collision2D colision) 
    {
        if (colision.transform.CompareTag("Player")) //Si hay una colision con el tag player
        {
            Debug.Log("Jugador Dañado"); //Se refleja por consola que el enemigo ha dañado al jugador
            colision.transform.GetComponent<JugadorRespawn>().JugadorGolpeado(); //Se volvera al ultimo punto de respawn o si no hay se reincia el nivel
        }
    }
}

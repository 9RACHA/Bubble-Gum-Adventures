using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //Para saber cuando el jugador a colisionado con el punto de guardado
    private void OnTriggerEnter2D(Collider2D colision) // Al colisionar con un elemento rigidbody
    {
        if (colision.CompareTag("Player")) //Si colisiona con el tag player
        {   //Guardara la posicion del punto de respawn
            colision.GetComponent<JugadorRespawn>().RespawnAlcanzado(transform.position.x,transform.position.y);
            //componente colision del script JugadorRespawn accede al metodo RespawnAlcanzado y cambiara la posicion de los ejes x e y
            GetComponent<Animator>().enabled = true; //Se obtiene el componente Animator y sera activada la animacion 
        }
    }
}

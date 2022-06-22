using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float Mover = 2; //Velocidad en eje horizontal -> X

    public float Salto = 4.5f; //Velocidad de salto en eje vertical -> Y 

    Rigidbody2D rigi; //Agrega fisicas para un componente 2D

    public SpriteRenderer sprite; //publico, para poder editarlo desde el inspector

    public Animator animado; //animacion del personaje

    //Start es llamado antes de la primera actualizacion Update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>(); //Para acceder a la jerarquia de unity y que el componente Rigidbody lo meta en la variable
    }

    
    void FixedUpdate() //Para trabajar con fisicas es mas recomendable que Update
    {
        //Serie de Condicionales que indicaran el estado del Personaje

        //Si se pulsa la tecla d del teclado O la tecla de dirección derecha 
        if (Input.GetKey("d") || Input.GetKey("right")) //Las letras en minuscula o dara error
        {
            rigi.velocity = new Vector2(Mover, rigi.velocity.y); //En Rigidbody la velocidad de Mover x variara en positivo e ira hacia la derecha
            sprite.flipX = false; //Dar la vuelta tiene que estar desactivado
            animado.SetBool("Correr", true); //La animacion pasara a estado verdadero
        }

        else if (Input.GetKey("a") || Input.GetKey("left")) //Si se pulsa la tecla A del teclado O la tecla de dirección izquierda
        {
            rigi.velocity = new Vector2(-Mover, rigi.velocity.y); //En Rigidbody la velocidad de mover -x variara en negativo e ira hacia la izquierda
            sprite.flipX = true; //Dar la vuelta tiene que estar activado
            animado.SetBool("Correr", true); //La animacion pasara a estado verdadero 
        }

        else
        {
            rigi.velocity = new Vector2(0, rigi.velocity.y); //Se quedara quieto el personaje 
            animado.SetBool("Correr", false); //La animacion pasara a estado falso estara desactivada
        }

        if (Input.GetKey("space") && ComprobarSuelo.tocaSuelo) // Si pulso espacio Y llamo a clase ComprobarSuelo con la variable tocaSuelo
        {
            rigi.velocity = new Vector2(rigi.velocity.x, Salto); //Salta, para eso se mantiene el eje X pero el Y se cambia junto con su variable Salto
        }

        if (ComprobarSuelo.tocaSuelo==false) //Si CompruebaSuelo.toca suelo es igual a falso, estara saltando
        {
            animado.SetBool("Saltar", true); //Saltar pasara a activado y se activara la animacion de salto
            animado.SetBool("Correr", false); //No se puede correr en el aire, la animacion de salto estara desactivada
        }

        if (ComprobarSuelo.tocaSuelo==true) //Si ComprobarSuelo.tocaSuelo es igual a verdadero, esta tocando suelo
        {
            animado.SetBool("Saltar", false); //La animacion de salto estara desactivada, saltar sera falso
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //Libreria para que el audio de las monedas se escuche al recogerlas 

public class RecogerMoneda : MonoBehaviour
{
    public AudioSource musica; //Representacion de fuente de audio

     private void OnTriggerEnter2D(Collider2D colision) //Cuando otro objeto entra en un colisionador anexo a este objeto
    {
        if (colision.CompareTag("Player")) //Si colisiona con el tag player el cual contiene un rigidbody
        {
            GetComponent<SpriteRenderer>().enabled = false; //Obtiene el componente SpriteRenderer activado igual a falso 
            gameObject.transform.GetChild(0).gameObject.SetActive(true); //El hijo obtendra 0 y el gameObject se activara en verdadero
            Destroy(gameObject, 0.5f); //Destruye el objeto y desaparece de la escena y el tiempo que tardara en desaparecer
            musica.Play(); //Activara la musica asociada a la moneda
            Debug.Log("Moneda recogida");
        }
    }
}

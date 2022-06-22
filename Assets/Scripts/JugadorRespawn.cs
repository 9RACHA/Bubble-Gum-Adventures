using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para cargar la escena 

public class JugadorRespawn : MonoBehaviour
{
    //Posicion X e Y para ubicar la posicion de respawn del jugador en el caso de interactuar con un punto de respawn
    private float RespawnPosicionX, RespawnPosicionY;

    // Start is called before the first frame update
    void Start()
    {   //PlayerPrefs es una clase que se utiliza para almacenar coordenadas 
        if (PlayerPrefs.GetFloat("RespawnPosicionX")!=0) //En el momento que sea distinto de 0 es que se ha asignado algun valor, GetFloat devuelve el valor correspondiente
        {   //Posicion de X e Y
            transform.position=(new Vector2(PlayerPrefs.GetFloat("RespawnPosicionX"),PlayerPrefs.GetFloat("RespawnPosicionY")));
        }
    }
    //Este metodo guarda la posicion si el jugador a alcanzado el respawn
    public void RespawnAlcanzado(float x, float y) 
    {   //Guardar una información
        PlayerPrefs.SetFloat("RespawnPosicionX", x); //Establece el valor float de la preferencia identificada por la clave dada en este caso del eje x
        PlayerPrefs.SetFloat("RespawnPosicionY", y); //Establece el valor float de la preferencia identificada por la clave dada en este caso del eje y
    }
    
    //Metodo que es llamado desde los enemigos o trampas
    public void JugadorGolpeado()
    {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Cargar la escena actual 
    }

}

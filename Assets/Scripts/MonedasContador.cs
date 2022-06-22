using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para cargar las escenas
using UnityEngine.UI; // Libreria referente al canvas

public class MonedasContador : MonoBehaviour
{   
    public Text nivelFinalizado; //Referenciar al texto del canvas que aparecera al finalizar el nivel

    public Text monedasTotales; //Referenciar al texto del canvas con la cantidad total de monedas en la escena

    public Text monedasCogidas; //Referencia a las monedas cogidas por el jugador

    private int monedasTotalesNivel; //Rereferencia en numero de las monedas por nivel

    private void Start()
    {
        monedasTotalesNivel = transform.childCount; // La variable monedasTotalesNivel es igual a sus objetos hijos 
    }

    //Cuando un metodo no quiero que devuelva nada uso void
    public void MonedasRecogidas()
    {
        if (transform.childCount==0) //Si los objetos hijos de MonedasRecogidas son iguales a 0
        {
            Debug.Log("Monedas Recogidas"); //Imprime por consola, en el juego no se refleja
            nivelFinalizado.gameObject.SetActive(true); //Activa el canvas al finalizar el nivel
            Invoke("CambiandoEscena", 1); //Para que tarde un segundo a mostrar el canvas
        }
    }

    private void Update()
    {
        MonedasRecogidas(); //Para saber constantemente si todas las monedas estan recogidas
        monedasTotales.text = monedasTotalesNivel.ToString(); //Referencia al texto monedasTotales es igual a monedasTotalesNivel en numero que pasara a gracias a ToString de manera String y se podra ver por pantalla
        monedasCogidas.text = (monedasTotalesNivel-transform.childCount).ToString(); //Incrementa en 1 el valor empezando desde 0 al recoger cada moneda
    }

    void CambiandoEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //Carga una escena, coge la escena actual y dentro de buildIndex suma 1 empieza por 0
    }

}

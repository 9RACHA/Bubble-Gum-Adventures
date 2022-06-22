using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    public float tiempoEmpieza = 200; //La variable tiempoEmpieza valdra 200
    public Text cajaTexto;  //El texto dentro del canvas 

    //El metodo es llamado antes de la primera actualizacion del frame
    void Start()
    {
        cajaTexto.text = tiempoEmpieza.ToString(); //Se inicia con valor ToString para convertir un numero 200 a un texto que muestre por pantalla
    }

    // Es llamado una vez por frame
    void Update()
    {
        tiempoEmpieza -= Time.deltaTime; //tiempoEmpieza resta 1 cada segundo gracias a deltaTime, que muestra el tiempo en segundos que tardó en completarse el último frame
        cajaTexto.text = Mathf.Round(tiempoEmpieza).ToString(); //Devuelve float redondeado al entero más cercano
    }
}

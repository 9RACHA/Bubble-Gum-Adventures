using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEnemigo : MonoBehaviour
{   //Para desarrollar una velocidad constante en el movimiento de la rana
    public float velocidadMax = 1f;
    public float velocidad = 1f;

    private Rigidbody2D rigi;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>(); //La variable rigi sera igual al valor de acceder al componente Rigidbody2D
    }

    // metodo mas optimo para fisicas que Update
    void FixedUpdate() 
    {
        rigi.AddForce(Vector2.right * velocidad); //Se añade una fuerza al rigidbody2D
        float velocidadLimitada = Mathf.Clamp(rigi.velocity.x, -velocidadMax, velocidadMax); //la variable velocidadLimitada sera igual al resultado entre los valores minimo y maximo para el eje x izquierda o derecha
        rigi.velocity = new Vector2(velocidadLimitada, rigi.velocity.y);

        if (rigi.velocity.x > -0.01f && rigi.velocity.x < 0.01f)    //si rigidbody.velocidad.x es mayor a -0.01f y rigi.velocity.x es menor a 0.01f
        {
            velocidad = -velocidad; 
            rigi.velocity = new Vector2(velocidad, rigi.velocity.y);
        }
        //Si es mayor a 0 debe moverse a la derecha 
        if (velocidad > 0)
        {
            transform.localScale = new Vector3(-3f, 3f, 1f); 
        }
        //Si es menor a 0 debe moverse a la izquierda
        else if (velocidad < 0)
        {
            transform.localScale = new Vector3(3f, 3f, 1f);
        }
    }
}

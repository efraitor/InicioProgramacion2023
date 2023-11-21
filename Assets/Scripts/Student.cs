using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    public string firstName = "Juan Alberto";
    public string lastName = "Mart�nez";
    public string email = "jamartinez@esimurcia.com";
    public int edad = 33;
    public int curso = 3;
    public float precioMatr�cula = 4500.50f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Para saber cuanto tiempo est� el juego en marcha y mostrarlo por consola
        //Debug.Log(Time.time); //time = tiempo que ha pasado desde que empez� un frame hasta que termina

        //Calculamos la altura a la que se encuentra el GameObject que tiene el script asociado
        float testObjectHeight = this.transform.position.y; //leer al rev�s (this = objeto donde est� metido el script)
        Debug.Log(testObjectHeight);
    }

    /* M�todo de Unity que funciona parecido al Update, es decir va a unos frames por segundo,
     * pero sus frames tienen el mismo tama�o. Pero es m�s lento que el Update.  Por ejemplo
     * en vez de ir a 30fps, va a 12-15 fps.
     * Sirve para hacer un movimiento suavizado al usar f�sicas
     */
    private void FixedUpdate()
    {
        Debug.Log(Time.time);
    }
}

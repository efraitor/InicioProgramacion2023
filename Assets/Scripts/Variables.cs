using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Esta librer�a contiene lo necesario para usar el motor Unity

/*
 * Variable = peque�a porci�n de memoria RAM donde podemos guardar un valor, que puede ir cambiando
 * Declaraci�n de una variable -> (p�blica o privada), tipo, nombre(si son dos palabras, las escribimos juntas pero la segunda palabra empieza en may�scula) = asignaci�n
 * Ejemplo:
 * 
 * public tipo nombre = valor;
 */
public class Variables : MonoBehaviour //MonoBehaviour significa que este Script deriva de ah�, es decir puede usar las propiedades de Unity
{
    /*
     * INICIALIZACI�N DE VARIABLES
     */
    //Variables p�blicas (accesibles desde el editor de Unity o desde otro Script)
    //int = n�mero de tipo entero sin decimales, positivo o negativo
    public int myNumber = 30;
    //Variables privadas (s�lo son accesibles desde este Script y se tiene en cuenta el lugar de definici�n con respecto al c�digo)
    //Si no ponemos public o private, autom�ticamente es private
    private int total; //Si no le asigno ning�n valor a una variable de tipo int es como si hubi�semos puesto un 0

    //Se llama antes de que empiece el juego
    private void Awake()
    {
        //Pondr�amos las variables o comportamientos que son necesarios antes de que comience el juego
    }

    //Se llama justo cuando empieza el juego
    // Start is called before the first frame update
    void Start()
    {
        //Pondr�amos las variables o comportamientos que son necesarios una vez el juego ha comenzado

        //A la variable total le asignamos el valor de (myNumber - 5)
        total = myNumber - 5; //total = 25;

        //Nos sirve para mostrar por consola el resultado de total en este caso
        Debug.Log(total);
        //Hago una suma que se va a mostrar en la consola
        Debug.Log(6 + 5);
        //Ponemos un mensaje que se muestra por la consola
        Debug.Log("Holi k tal?");
        //Combinamos lo de arriba
        Debug.Log("Tu eres tonto?" + 2 + 2);
    }

    //Se llama una vez cada frame
    // Update is called once per frame
    void Update()
    {
        //Pondr�amos las variables o comportamientos que son necesarios mientras el juego se est� ejecutando
    }
}

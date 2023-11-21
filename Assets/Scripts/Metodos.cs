using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    /*
     * INICIALIZACI�N DE VARIABLES
     */
    public int number1 = 5;
    public int number2 = 8;
    //string = cadena de caracteres que tenemos que asignarle a la variable entre comillas dobles
    public string persona = "Antonio";
    //float = n�meros con parte decimal, al asignarle un valor debe acabar en f
    public float decimalNumber = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Llamamos al primer tipo de m�todo para que funcione al empezar el juego
        AddTwoNumbers();
        //Llamamos al segundo tipo de m�todo en el que le damos los valores que queremos pasarle entre par�ntesis
        AddTwoNumbers2(6, 4); //El resultado ser� 10
        AddTwoNumbers2(8, 3); //El resultado ser� 11
        //Llamamos al tercer tipo de m�todo
        Debug.Log(AddTwoNumbers3(3, 4)); //Este Debug.Log mostrar� por consola el resultado de la suma, osea la variable result
        //hay otra manera de hacer lo de arriba
        int suma = AddTwoNumbers3(3, 4); //As� podr�amos sacar el valor de result para usarlo en el m�todo Start
        Debug.Log(suma);
        //Saludamos a las dos personas
        SayHello("Pablo", "Mar�a");
        //Multiplicar un n�mero decimal por dos
        DoubleNumber(3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Primer tipo de m�todo, que coge variables de fuera y hace su acci�n (lo que est� entre llaves)
    public void AddTwoNumbers()
    {
        //Cada vez que ejecutamos el m�todo se sumar�an las variables que hemos creado antes y se mostrar�an por pantalla
        Debug.Log(number1 + number2);
    }

    //Segundo tipo de m�todo, las variables se pasan al m�todo por par�metros y hace su acci�n cuando lo llamamos
    public void AddTwoNumbers2(int firstNumber, int secondNumber)//Los par�metros son valores o referencias que le tenemos que pasar al m�todo a la misma vez que lo llamamos para que funcione
    {
        //Ahora se van a sumar los dos param�tros que le hayamos pasado y se van a mostrar en pantalla
        Debug.Log(firstNumber + secondNumber);
    }

    //Tercer tipo de m�todo, le pasamos par�metros, el m�todo tiene tipo de variable y devuelve una variable de ese tipo elegido
    public int AddTwoNumbers3(int firstNumber, int secondNumber)
    {
        //Creo una variable privada del m�todo, para guardar el resultado de la suma
        int result = firstNumber + secondNumber;
        //Devuelvo el valor de la variable, que tiene que ser del mismo tipo que el del m�todo
        return result;
    }

    /*
     * Un m�todo que salude a la vez a dos personas dadas
     * Un m�todo que multiplique un n�mero decimal por dos
     * Ambos m�todos se mostrar�n por consola
     */
    void SayHello(string userName, string userName2)
    {
        Debug.Log("Hello " + userName + " y " + userName2);
    }

    void DoubleNumber(float number)
    {
        Debug.Log(2.0f * number);
    }
}

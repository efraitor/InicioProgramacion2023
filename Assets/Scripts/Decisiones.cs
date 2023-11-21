using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decisiones : MonoBehaviour
{
    public bool willItRainToday;

    // Start is called before the first frame update
    void Start()
    {
        /* Ejemplo condicional:
         * if(condici�n)
         * {
         * //Lo que ocurre si se cumple
         * }
         * else
         * {
         * //Lo que ocurre sino se cumple
         * }
         */

        //Si hoy va a llover (si la variable es true)
        if(willItRainToday) //en este caso comprobamos si es true, tambi�n se podr�a escribir as� -> if(willItRainToday == true)
        {
            Debug.Log("Coger el parag�as");
        }
        //Si hoy no va a llover (si la variable es false)
        else
        {
            Debug.Log("No hace falta coger nada");
        }

        //Si no llueve iremos al cine (comprobamos si la variable es false)
        if (!willItRainToday) //con ! comprobamos que no se cumpla o que no sea verdadera
        {
            Debug.Log("Vamos al cine");
        }

        //Acelerar si llego tarde y no hay tr�fico
        bool iAmLate = true;
        bool isThereNotSomeTraffic = false;
        if (iAmLate && isThereNotSomeTraffic) // && = AND, significa que ambas condiciones deben ser ciertas a la vez
        {
            Debug.Log("�Corre pl�tano!");
        }
        //Si una de las dos condiciones no es cierta
        else
        {
            Debug.Log("O bien hay tr�fico, o bien no llego tarde");
        }

        //Si uno u otros tienen hambre hacemos la comida
        bool iAmHungry = true;
        bool kidsAreHungry = false;
        if(iAmHungry || kidsAreHungry) // || = OR, significa que una u otra debe ser cierta
        {
            Debug.Log("Vamos a hacer la comida");
        }
        //Ninguna de las dos es cierta
        else
        {
            Debug.Log("Nadie tiene hambre");
        }

        //Condicionales concatenados
        //Varios else
        //Seg�n la velocidad permitida de un coche
        int maxSpeed = 75; //Velocidad m�xima en la carretera en la que vamos

        if(maxSpeed == 120) //== es un comparador
        {
            Debug.Log("Podemos ir a fondo");
        }
        //Y si
        else if(maxSpeed < 120 && maxSpeed >= 60)
        {
            Debug.Log("Podemos ir a velocidad de cruce");
        }
        else if(maxSpeed < 60 && maxSpeed >= 40)
        {
            Debug.Log("Debemos ir a velocidad de ciudad");
        }
        else if(maxSpeed < 40 && maxSpeed > 0)
        {
            Debug.Log("Llevamos delante a un cabr�n con la L");
        }
        else if(maxSpeed == 0)
        {
            Debug.Log("Tamoh de botell�n");
        }
        //Si no se cumple nada de lo de arriba, este ser� el por defecto
        else
        {
            Debug.Log("Velocidad no v�lida");
        }

        //Hay una estructura que ser�a equivalente a lo que hemos escrito arriba. El condicional Switch
        //Un Switch se usar�a preferiblemente en aquellos casos en los que estemos analizando el valor cambiante de una sola variable
        switch (maxSpeed)
        {
            case 120:
                {
                    Debug.Log("Podemos ir a fondo");
                    break; //Saltamos lo que queda de Switch si se ha cumplido este caso
                }
            case >= 60:
                {
                    Debug.Log("Podemos ir a velocidad de cruce");
                    break; //Saltamos lo que queda de Switch si se ha cumplido este caso
                }
            case >= 40:
                {
                    Debug.Log("Podemos ir a velocidad de ciudad");
                    break; //Saltamos lo que queda de Switch si se ha cumplido este caso
                }
            case > 0:
                {
                    Debug.Log("Llevamos delante a uno con L");
                    break; //Saltamos lo que queda de Switch si se ha cumplido este caso
                }
            case 0:
                {
                    Debug.Log("Tamoh de botell�n");
                    break; //Saltamos lo que queda de Switch si se ha cumplido este caso
                }
            default:
                {
                    Debug.Log("Velocidad no v�lida");
                    break; //Saltamos lo que queda de Switch si se ha cumplido este caso
                }
        }

        //Ejemplo de if/else sin llaves
        /*
         * if(condicion)
         * //lo que hace
         * else
         * //lo que hace
         */

        //Y en aquello casos en los que un if y un else trabajan sobre la misma variable se usa el operador Ternario
        //if (dinero >= 40)
        //{
        //    puedoComprarJuego = true;
        //}
        //else
        //{
        //    puedoComprarJuego = false;
        //}
        //Esta l�nea equivale al if/else de arriba
        //puedoComprarJuego = (dinero >= 40) ? true : false;

        
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos una tecla se mostrar� un mensaje en la consola
        if (Input.GetKeyDown(KeyCode.P))
            Debug.Log("�Sabe usted que es lo que quiero?");
    }
}

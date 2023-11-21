using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int age;
    public bool isMale;
    public bool isMarried;

    public Persona spouse;

    //Constructor de la clase persona por Defecto
    public Persona()
    {

    }

    //Constructor de la clase Persona usando solo nombre y apellido
    public Persona(string pFirstName, string pLastName) //Cuando vaya a usar este constructor tendr� que pasarle esos dos par�metros
    {
        //De esa persona concreta que estamos construyendo cojo el par�metro y lo meto
        //en la variable que hab�amos creado
        firstName = pFirstName;
        lastName = pLastName;
    }

    //Constructor de la clase Persona usando todos los datos
    public Persona(string pFirstName, string pLastName, int pAge, bool pIsMale, bool pIsMarried)
    {
        //De esa persona concreta que estamos construyendo cojo el par�metro y lo meto
        //en la variable que hab�amos creado
        firstName = pFirstName;
        lastName = pLastName;
        age = pAge;
        isMale = pIsMale;
        isMarried = pIsMarried;
    }

    //M�todo al que le pasamos una persona para saber si est� casada con otra
    //Este m�todo solo nos devuelve verdadero o falso
    public bool IsMarriedWith(Persona otherPerson)
    {
        //Compruebo primero si esa persona est� casada o tiene esposo/a
        if (spouse == null) //si la persona que yo estoy comprobando est� soltera, no tiene esposo/a
        {
            Debug.Log("No est� casado/a");
            return false;
            //aqu� no est� casado/a
        }
        //Y si la persona est� casado/a
        else
        {
            Debug.Log("Est� casado/a");
            //Si los nombres y apellidos de los esposos/as de las personas que estamos comprobando coinciden
            if(otherPerson.firstName == spouse.firstName &&
                otherPerson.lastName == spouse.lastName)
            {
                Debug.Log("Est�n casados entre s�");
                return true;
                //aqu� est� casado/a con otherPerson
            }
            //Y si est� casado/a pero con otra persona distinta
            else
            {
                Debug.Log("Est�n casados/as pero no entre s�");
                return false;
                //aqu� est� casado/a pero no con otherPerson
            }
        }
    }
}

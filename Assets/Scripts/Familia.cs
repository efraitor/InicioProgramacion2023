using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familia : MonoBehaviour
{
    //Estas personas derivan de la clase persona (usamos informaci�n de esa clase)
    public Persona father;
    public Persona mother;
    public Persona son;

    // Start is called before the first frame update
    void Start()
    {
        //Aqu� estar�a usando el constructor por defecto para definir al padre
        //father = new Persona(); //Instanciando la nueva persona (inicializando)
        //father.firstName = "Juan Alberto"; //despu�s de instanciar, podemos inicializar las variables
        //father.lastName = "Mart�nez";
        father.age = 33;
        father.isMale = true;
        father.isMarried = true;
        //Aqu� usar�amos el segundo tipo de constructor que hemos creado
        father = new Persona("Juan Alberto", "Mart�nez");
        //Aqu� usar�amos el tercer tipo de constructor que hemos creado
        //father = new Persona("Juan Alberto", "Mart�nez", 33, true, true);

        //mother = new Persona("Alicia", "Fern�ndez", 30, false, true);
        //mother = new Persona();
        //mother.firstName = "Alicia";
        //mother.lastName = "Fern�ndez";
        //mother.age = 30;
        //mother.isMale = false;
        mother.isMarried = true;

        //El padre tiene como esposa a la madre
        father.spouse = mother;
        //La madre tiene como esposo al padre
        mother.spouse = father;
        //Compruebo si esas dos personas est�n casadas entre s�
        if (father.IsMarriedWith(mother))
        {
            Debug.Log(father.firstName + " y " + mother.firstName + " est�n casados.");
        }
        else
        {
            Debug.Log(father.firstName + " y " + mother.firstName + " no est�n casados.");
        }

        son = new Persona();
        son.firstName = "Gabriel";
        son.lastName = "Mart�nez";
        son.age = 7;
        son.isMale = true;
        son.isMarried = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

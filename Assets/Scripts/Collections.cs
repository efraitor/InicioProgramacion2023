using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public string student1 = "Christian";
    public string student2 = "Kate";
    public string student3 = "Mia";
    public string student4 = "Robert";

    //Todas las estructuras de datos empiezan en la posici�n n�mero 0
    //El �ltimo elemento de un array es el de su dimensi�n -1

    /*
     * ARRAY
     * - Es homog�neo (solo un tipo de dato)
     * - Es de tama�o fijo (una vez creado, no puede contener m�s elementos)
     * - Tiene un orden (se accede por posici�n)
     */
    public string[] students = new string[] { "Christian", "Kate", "Mia", "Robert" };
    public string[] familyNames = new string[4]; // { , , , }
    int[] numberOfDoorsInMyStreet = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
    private bool[] hasPassedTheExam = new bool[] { true, false, true, false };

    /*
     * LISTAS (Bolsillo m�gico)
     * - Es homog�neo (solo un tipo de dato)
     * - Es de tama�o ajustable o variable (podemos a�adir m�s elementos en tiempo real y eliminarlos)
     * - Tiene un orden (se accede por posici�n)
     */
    public List<string> studentNames = new List<string>();

    /*
     * ARRAYLIST (Bolsillo de Doraemon)
     * - Es heterog�neo (puede guardar diferentes tipos de datos en la misma estructura)
     * - Es de tama�o ajustable o variable (podemos a�adir m�s elementos en tiempo real y eliminarlos)
     * - Tiene un orden (se accede por posici�n)
     */
    public ArrayList inventory = new ArrayList();

    /*
     * DICCIONARIO <-> HASHTABLE
     * - Es heterog�neo (puede guardar diferentes tipos de datos en la misma estructura)
     * - Es de tama�o ajustable o variable (podemos a�adir m�s elementos en tiempo real y eliminarlos)
     * - Se accede por clave (no por posici�n)
     */

    public Hashtable personalDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        /*
         * LISTAS
         */
    //ADD -> a�ade elementos a una lista al final de la lista
    //Aqu� la lista est� vac�a
    studentNames.Add("Christian");
        //Aqu� la lista tiene un elemento, Christian
        studentNames.Add("Kate");
        //Aqu� la lista tiene dos elementos, Christian y Kate
        studentNames.Add("Mia");
        //Aqu� la lista tiene tres elementos, Christian, Kate y Mia
        studentNames.Add("Robert");
        //Aqu� la lista tiene cuatro elementos, Christian, Kate, Mia, y Robert
        studentNames.Add("Jack");
        //Aqu� la lista tiene cinco elementos, Christian, Kate, Mia, Robert y Jack

        //CONTAINS -> nos dice si la lista contiene o no un objeto
        if (studentNames.Contains("Jack"))
        {
            //REMOVE -> elimina elementos de la lista
            studentNames.Remove("Jack");
        }

        //INSERT -> Podemos meter elementos nuevos en la lista en una posici�n
        studentNames.Insert(2, "Paul");
        //Ahora el orden es Christian, Kate, Paul, Mia, Robert

        //TOARRAY() -> Convierte una lista en un array
        string[] studentNamesToArray = studentNames.ToArray();

        //CLEAR() -> Elimina definitivamente todos los elementos de la lista
        //studentNames.Clear();
        //Ahora la lista estar� vac�a

        /*
         * Acceso a arrays y tama�o de los mismos
         */
        //LENGTH -> Nos indica el tama�o del array
        Debug.Log("El tama�o del array de estudiantes es: " + students.Length);

        int pos = 0;
        //Comprobamos que la posici�n que le pasamos est� contenida en el array
        if(pos >= 0 && pos < students.Length)
        {
            //Nos muestra la posici�n que le hemos pasado en par�metro students[posici�n]
            Debug.Log("El primer estudiante del array es: " + students[pos]);
        }

        /*
         * Acceso a las listas y tama�o de las mismas
         */
        //COUNT -> Nos indica el tama�o de la lista
        Debug.Log("El tama�o de la lista de estudiantes es: " + studentNames.Count);

        pos = 2;
        if(pos >= 0 && pos < studentNames.Count)
        {
            string thirdStudent = studentNames[pos];
            Debug.Log("El tercer estudiante de la lista es: " + thirdStudent);
        }

        /*
         * ARRAYLIST
         */
        inventory.Add(30);
        inventory.Add(3.14159265f);
        inventory.Add("Juan Alberto");
        inventory.Add(false);
        //Buscamos un objeto en la escena que est� etiquetado como Arma y lo guardamos en el ArrayList
        inventory.Add(GameObject.FindGameObjectsWithTag("Arma"));

        //Pedimos el tipo de dato que va a salir de la ArrayList
        Debug.Log(inventory[2].GetType());
        Debug.Log(inventory[4].GetType());

        /*
         * HASHTABLE
         */
        //Ponemos clave y valor
        personalDetails.Add("firstName", "Juan Alberto");
        personalDetails.Add("lastName", "Mart�nez");
        personalDetails.Add("age", 33);
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", false);
        personalDetails.Add("hasChildren", false);

        if(personalDetails.Contains("firstName") && personalDetails.Contains("age"))
        {
            //Tenemos que hacer cast (convertir un tipo de variable en otra para poder usarla)
            string name = (string)personalDetails["firstName"];
            int ageVariable = (int)personalDetails["age"];
            Debug.Log(name);
            Debug.Log(ageVariable);
        }
        else
        {
            Debug.Log("El diccionario no contiene las claves que se han pedido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

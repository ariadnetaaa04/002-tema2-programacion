using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    This is a multiline comment: 
    4 variables with the player's info
    */

    //This variable saves the player's age
    public int playerAge = 33;

    //This variable saves the player's speed
    public float playerSpeed = 3.125f;

    //This variable saves the player's username
    public string playerName = "ariadneta";

    //This variable saves if the player has lost
    [SerializeField]
    private bool gameOver = false; // Has the player lost? 

    //Show a message in the consol
    public string message = "Esta es tu puntuacion";
    public int points = 256;

    /*
    private float x = 7;
    private float y = 4;
    private float result;
    */

    public int x = 11;
    public int y =11;
    private bool areEqual;

    public string name1 = "Arix";
    public string name2 = "Arix";

    //Declaraciones condicionales
    private bool areDifferent;
    private bool isGreater;
    private bool isLesser;

    //Declaraciones decisión
    public bool isRaining;
    public float number;
    public int number1;
    public int number2;

    //modificar posicion
    public Vector3 initialPos = new Vector3(1, 1, 1);


    private void Start()
    {
        /*
        Debug.Log(message); //It's changed in the inspector 
       
        Debug.Log(points); //It shows the point written in the variable named "points"
        
        Debug.Log("Enhorabuena"); //It shows the text written

        Debug.Log($"Tengo {points} puntos"); //It mixes text and a variable 

        Debug.Log( message: string.Format("Hola {0}, tines {1} puntos", playerName, points));

        Debug.Log(message: "Tengo" + points + " puntos");

        

        // Suma
        result = x + y;
        Debug.Log($"{x} + {y}= {result}");

        //Resta
        result = x - y;
        Debug.Log($"{x} - {y}= {result}");

        //Product
        result = x * y;
        Debug.Log($"{x} * {y}= {result}");

        //Divison
        result = x / y;
        Debug.Log($"{x} / {y}= {result}");

        //Modulo
        result = x % y;
        Debug.Log($"{x} % {y}= {result}");

        

        //Igualdad
        areEqual = x == y;
        Debug.Log(areEqual);

        //Desigualdad
        areDifferent = name1 != name2;
        Debug.Log(areDifferent);

        // mayor
        isGreater = x > y;
        Debug.Log(isGreater);

        //menor
        isLesser= x < y;
        Debug.Log(isLesser);
        

        //Decision
        if (true) {
            Debug.Log("La condicion es verdadera");
        }
        

        //Decisio II
    if(isRaining==true)
        {
            Debug.Log("Recuerda coger paraguas para no mojarte");
        }

    //Decisio III
        if (number > 0)
        {
            Debug.Log($"El numero {number} es positivo");
        }

        else
        {
            Debug.Log($"El numero {number} No es positivo");
        }

        */
    //Decisio IV
        if (number1 == number2)
        {
            Debug.Log("Los dos numeros son iguales");
        }


        if (number > 5)
        { Debug.Log($"Has sacado un {number}, has aprobado!");
        }
        else if (number < 5)
        {
            Debug.Log($"Has sacado un {number}, has suspendido");
        }
        else
        {
            Debug.Log($"Has sacado un {number}, has aprobado pero justo. Estudia mas!");
        }



        //AND && --> Tienen que darse las dos condiciones para que se cumpla

        //OR || --> Tiene que darse una condicion para que se cumpla

        //Modificar posicion
        transform.position = initialPos;

        //Negacion: La variable es falsa? Si pone false es que no.

        //X(dreta,esquerra) Y (adalt,abaix) Z(devant,darrera)

        //Modificar posicion con el Update/Input


    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position += Vector3.up;
        }
    }

}


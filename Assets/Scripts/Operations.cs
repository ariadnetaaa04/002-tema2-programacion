using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 7;
    public float y = 4;
   
    // Start is called before the first frame update
    void Start()
    {
        Calculator(x, y);  
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Calculator(x, y);
        }
    }

    private void Calculator(float x, float y)
    {
        Debug.Log($"Sum: {x} + {y} = {x + y}");
        Debug.Log($"Substraction: {x} - {y} = {x - y}");
        Debug.Log($"Product: {x} * {y} = {x * y}");
        Debug.Log($"Division: {x} / {y} = {x / y}");
    }
}

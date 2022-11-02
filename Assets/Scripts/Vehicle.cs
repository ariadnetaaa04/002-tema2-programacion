using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // This saves the number of wheels of the vehicle.
    [SerializeField]
    private int wheels = 4;

    [SerializeField]
    private string name ="";
    public string sound;
    public float gasoline;

    public bool isOn;

    private void Start()
    {

        // Debug.Log ($"The { name} has { wheels} wheels.");


        /*
         if (isOn == true)
         {
             Debug.Log($" The {name} is on");
         }else{
             Debug.Log($"The {name} is off");

         }

         //Else if 
         if (isOn == false)
         { Debug.Log($"The {name} is off");
         }
         else if (sound!= "")
         { Debug.Log($"The {name} is on and does brum brum");
         }
         else { Debug.Log($"The {name} is on"); }


         //If dentro de otro if
         if (isOn == true)
         { if (gasoline < 10)
                 Debug.Log($"The {name} has low gasoline!");
             else 
                 Debug.Log($"The {name} has gasoline");
         }
         else
         {
             Debug.Log($"The {name} is off");
         }
        */
     
      if (gasoline < 10 && isOn == true) { 
                Debug.Log($"The {name} has low gasoline!");
        }
        else
        {
            Debug.Log($"The {name} is off");
        }

    }

}

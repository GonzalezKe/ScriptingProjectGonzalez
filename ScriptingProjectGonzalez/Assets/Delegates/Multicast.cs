using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multicast : MonoBehaviour
{

    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    // Start is called before the first frame update
    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if(myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PowerUp()
    {
        print ("Orb is powering up!");
    }

    void TurnRed()
    {
  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SomeClass myClasss = new SomeClass();

        myClasss.Add (1, 2);
        myClasss.Add ("Hello", "World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

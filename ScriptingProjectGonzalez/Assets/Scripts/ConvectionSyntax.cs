using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvectionSyntax : MonoBehaviour
{
    public Object I { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        // This line there to tell me the X position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
        



    }
}

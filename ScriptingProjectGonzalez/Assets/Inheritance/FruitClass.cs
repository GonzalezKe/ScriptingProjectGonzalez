using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass : MonoBehaviour
{

    public string color;

    public FruitClass()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public FruitClass(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constuctor Called");
    }

    public void Chop()
    {
        Debug.Log("Theb " + color + " fruit has been chopped. ");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

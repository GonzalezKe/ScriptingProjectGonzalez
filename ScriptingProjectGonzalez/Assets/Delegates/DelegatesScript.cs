using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatesScript : MonoBehaviour
{

    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintNum(int num)
    {
        print("print Num: " + num * 2);
    }

    void DoubleNum(int num)
    {
        print ("double Num: " + num * 2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
 
    void Start()
    {
        var myTest = new Test(5, 2);
        myTest.GetSum();
        Debug.Log(myTest.result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

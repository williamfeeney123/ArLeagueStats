using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTank : MonoBehaviour
{

    public bool isRotating = true;
    // Update is called once per frame
    void Update()
    {
       if(isRotating)
        {
            transform.Rotate(0f, 2f,0f);
        }
    }
}

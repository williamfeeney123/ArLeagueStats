using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTank : MonoBehaviour
{
    public bool isRotating;

    // Start is called before the first frame update
    void Start()
    {
        isRotating = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0f, 2.0f, 0f);
        }
    }
}

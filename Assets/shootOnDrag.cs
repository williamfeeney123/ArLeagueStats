using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class shootOnDrag : MonoBehaviour
{
    public ARGestureInteractor arGestureInteractor;
    public GameObject Bullet;
    Vector3 startDragPosition;
    public Transform bulletPos;
    // Start is called before the first frame update
    void Start()
    {
        arGestureInteractor = Camera.main.GetComponent<ARGestureInteractor>();
        arGestureInteractor.DragGestureRecognizer.onGestureStarted += OnDragStart;
    }

    private void OnDragStart(DragGesture obj)
    {
       GetComponent<rotateTank>().isRotating = false;
       obj.onFinished += OnDragEnd;
        startDragPosition = Input.mousePosition;
    }

    private void OnDragEnd(DragGesture obj)
    {
        Vector3 diffVector = Input.mousePosition - startDragPosition;
        GetComponent<rotateTank>().isRotating = true;

        GameObject newPrefab = Instantiate(Bullet);
        newPrefab.transform.position = bulletPos.transform.position;
        Vector3 bulletForce = transform.forward + new Vector3(0f, 1f, 0f);
        bulletForce *= diffVector.magnitude * 0.01f; //add a varaible;
        newPrefab.GetComponent<Rigidbody>().AddForce(bulletForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

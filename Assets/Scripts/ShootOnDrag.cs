using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ShootOnDrag : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPos;
    public ARGestureInteractor arGestureInteractor;
    Vector3 startDragPos;

    // Start is called before the first frame update
    void Start()
    {
        arGestureInteractor = Camera.main.GetComponent<ARGestureInteractor>();
        arGestureInteractor.DragGestureRecognizer.onGestureStarted += OnDragStart;
    }

	private void OnDragStart(DragGesture obj)
	{
        obj.onFinished += OnDragComplete;
        GetComponent<RotateTank>().isRotating = false;
        startDragPos = Input.mousePosition;
    }

    private void OnDragComplete(DragGesture obj)
    {
        GetComponent<RotateTank>().isRotating = true;

        Vector3 diffVec = Input.mousePosition - startDragPos;
        GameObject newPrefab = Instantiate(bulletPrefab);
        newPrefab.transform.position = bulletPos.position;

        //Vector3 bulletForce = transform.forward + new Vector3(0f, 1f, 0f);
        //bulletForce *= (diffVec.magnitude * 0.01f);
        //newPrefab.GetComponent<Rigidbody>().AddForce(bulletForce, ForceMode.Impulse);

    }
}

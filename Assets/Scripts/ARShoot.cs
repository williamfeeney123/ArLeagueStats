using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    ARGestureInteractor arGestureInteractor;
    public float shotSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        arGestureInteractor = GetComponent<ARGestureInteractor>();

        arGestureInteractor.TapGestureRecognizer.onGestureStarted += OnTapRecognized;
        arGestureInteractor.DragGestureRecognizer.onGestureStarted += OnDragRecognized;
    }

	private void OnDragRecognized(DragGesture obj)
	{
        Debug.Log("DRAG START");

        obj.onFinished += OnDragComplete;
	}

	private void OnDragComplete(DragGesture obj)
	{
        Debug.Log("DRAG COMPLETE");
    }

	private void OnTapRecognized(TapGesture obj)
	{
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.position = transform.position;

        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Vector3 TargetPos;
    public float Speed = 0.5f;

    void Update()
    {
        Vector3 directionToTarget = TargetPos - transform.position;

        if (directionToTarget.magnitude < Speed * Time.deltaTime)
        {
            transform.position = TargetPos;
        }
        else
        {
            transform.position += directionToTarget.normalized * Speed * Time.deltaTime;
        }
    }

}

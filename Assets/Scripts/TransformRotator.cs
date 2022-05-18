using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class TransformRotator : MonoBehaviour
{
    //public GameObject target;

    public Transform target;
    public float speed = 45f;
    void Update()
    {
        // Spin the object around the target at ... degrees/second.
       // transform.RotateAround(target.transform.position, Vector3.up, 40 * Time.deltaTime);

       float angleDelta = speed * Time.deltaTime;
        Vector3 rotationDelta = new Vector3(angleDelta, 0,0);
        
        target.Rotate(rotationDelta);
    }
}

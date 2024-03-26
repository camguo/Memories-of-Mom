using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothSpeed = 5;

    void Awake()
    {

    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(target.transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }

    public void AssignTarget(Transform newTarget)
    {
        target = newTarget;
    }
}

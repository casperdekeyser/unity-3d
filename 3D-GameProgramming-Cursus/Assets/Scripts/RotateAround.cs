using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public int Speed;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            target = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // RotateAround takes three arguments: vector to rotate around, axis of a vector to turn around, degrees to rotate
        transform.RotateAround(target.transform.position, target.transform.up, Speed * Time.deltaTime);
    }
}

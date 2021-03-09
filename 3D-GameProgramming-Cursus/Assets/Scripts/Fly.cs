using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    Transform tranform;
    Rigidbody rb;

    bool boost;

    // Start is called before the first frame update
    void Start()
    {
        tranform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        rb.AddForce(0, v, 0);


        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        //rigid.AddForce(0, 0, h * 0.2f);
        transform.Rotate(h * 0.1f, 0, 0);

        boost = CrossPlatformInputManager.GetButton("Jump");
        if (boost)
        {
            rb.AddRelativeForce(0, 1, 0);
        }

    }
}

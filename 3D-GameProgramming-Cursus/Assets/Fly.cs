using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Fly : MonoBehaviour
{
    [SerializeField]
    public float boostForce;
    public float steerForce;
    
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
        // Steering
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        transform.Rotate(h * steerForce/10, 0, 0);

        
        // Fly up
        boost = CrossPlatformInputManager.GetButton("Jump");
        if (boost)
        {
            rb.AddRelativeForce(0, boostForce, 0);
        }
    }
}

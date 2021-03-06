using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] float thrustForce = 10f;
    [SerializeField] float steerForce = 10f;

    Rigidbody rb;
    bool thrust = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.Space);

        if(!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, steerForce * Time.deltaTime));
        }

        rb.freezeRotation = false;
    }

    private void FixedUpdate()
    {
        if (thrust) rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
    }
}

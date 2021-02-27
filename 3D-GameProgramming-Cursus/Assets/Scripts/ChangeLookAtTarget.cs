using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAtTarget : MonoBehaviour
{

    public GameObject target; // target where camera should look at

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        // change target of the LookAtTarget script
        LookAtTarget.target = target;

        // change the field of view on the perspective camera based on the distance from center of world, clamp it to a reasonable field of view
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
}

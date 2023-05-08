using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerfollow : MonoBehaviour
{
    public Transform target;
   // public Vector3 offset;

   // [Range(1,10) ]
    //public float smoothfactor;

    // Start is called before the first frame update
    void Start()
    {
        Follow();
    }

    // Update is called once per frame
    void Follow()

    {
        transform.position= target.position;

        /*  Vector3 targetPosition = target.position ;
           Vector3 smothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothfactor*Time.fixedDeltaTime);
            transform.position = targetPosition;  + offset*/
    }
}

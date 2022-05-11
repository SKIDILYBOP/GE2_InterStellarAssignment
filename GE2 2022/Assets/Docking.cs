using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Docking : MonoBehaviour
{
    public Vector3 currentTarget;
    public Transform enduranceTarget;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTarget = GetComponent<Pursue>().targetPos;

        if (Vector3.Distance(transform.position,currentTarget) < .25f )
        {
            transform.parent = enduranceTarget;
            transform.localPosition = Vector3.zero;
            transform.Translate(0,-.5f, 0);
            GetComponent<Boid>().enabled = false;
            
        }

    }
}

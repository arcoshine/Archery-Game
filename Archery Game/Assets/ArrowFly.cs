using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFly : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 velos;
    private Vector3 accels;
    void Start()
    {
        velos = Vector3.Normalize(transform.TransformVector(Vector3.forward)) * 2.0f; //set vector for arrow movement at 2m/s initially
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((velos * Time.deltaTime), Space.World); //move the arrow at correct velocities for time between movements
        Debug.Log(velos * Time.deltaTime); //check how far the arrow moved
        Debug.Log(velos); //output velocities after normalisation
        Debug.Log(Time.deltaTime); //check how far the arrow moved
    }
}

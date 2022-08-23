using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFly : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 velos; //velocity in each direction
    private Vector3 accels; //acceleration in each direction
    private Vector3 gravFor; //force downwards due to gravity
    public int gravity; //value of g
    private Vector3 dragFors; //forces in each direction
    void Start()
    {
        velos = Vector3.Normalize(transform.TransformVector(Vector3.forward)) * 2.0f; //set vector for arrow movement at 2m/s initially
    }

    // Update is called once per frame
    void Update()
    {
        velos = velos + (Time.deltaTime * accels); //calculate new velocity given acceleraction
        var displacement = velos * Time.deltaTime - (0.5f * accels * Mathf.Pow(Time.deltaTime, 2.0f)); //calculate the displacement in the given period
        transform.Translate(displacement, Space.World); //move the arrow at correct velocities for time between movements
        Debug.Log(displacement); //check how far the arrow moved
    }
}

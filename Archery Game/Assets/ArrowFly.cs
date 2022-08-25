using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFly : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 velos; //velocity in each direction
    public Vector3 accels; //acceleration in each direction
    public Vector3 gravFor; //force downwards due to gravity
    public float gravity = 9.8f; //value of g
    public Vector3 dragFors; //forces in each direction
    private FireArrow fireArrow; //used to reference FireArrow script
    public GameObject camera_m; //used to reference the Main Camera
    private float timeDown; //used to represent time that fire 1 was held down
    void Start()
    {
        camera_m = GameObject.FindWithTag("MainCamera"); //get reference to the main camera
        fireArrow = camera_m.GetComponent<FireArrow>(); //get reference to FireArrow
        timeDown = fireArrow.timeHeld; //Fire timeHeld
        velos = Vector3.Normalize(transform.TransformVector(Vector3.forward)) * 10.0f; //set vector for arrow movement at 2m/s initially
        velos = Mathf.Min(Mathf.Sqrt(timeDown), 20.0f) * velos; //adjust 
    }

    // Update is called once per frame
    void Update()
    {
        velos = velos + (Time.deltaTime * accels); //calculate new velocity given acceleraction
        var displacement = velos * Time.deltaTime - (0.5f * accels * Mathf.Pow(Time.deltaTime, 2.0f)); //calculate the displacement in the given period
        transform.Translate(displacement, Space.World); //move the arrow at correct velocities for time between movements
        //Debug.Log(velos); //check how far the arrow moved
    }
    public void getTimeHeld(float timeDown)
    {
        //Debug.Log(velos + "getTimeHeld");
    }
}

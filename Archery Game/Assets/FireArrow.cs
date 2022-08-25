using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objFired;
    public float timeHeld; //time that the left click is held
    public float timeStart; //the time the left click button is pressed down
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            timeStart = Time.time;
        }
        if(Input.GetButtonUp("Fire1")) //when the Fire1 key (left click) is pressed
        {
            timeHeld = Time.time - timeStart;
            SpawnArrow(timeHeld); //spawn an arrow
        }
    }
    void SpawnArrow(float drawTime)
    {
        //spawn the arrow
        var arrowNew = Instantiate(objFired, (transform.position + transform.forward), transform.rotation); //create object 1 unit infront of viewe
        arrowNew.AddComponent<ArrowFly>(); //give new object script
    }
}
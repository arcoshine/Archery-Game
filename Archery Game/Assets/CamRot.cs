using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRot : MonoBehaviour
{
    // Start is called before the first frame update
    float MouseX = 0; //for horizontal rotation
    float MouseY = 0; //for vertical rotation
    float Sens = 1; //for mouse sensitivity
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseX += Input.GetAxis("Mouse X") * Sens; //get change in mouse horizontally
        MouseY += Input.GetAxis("Mouse Y") * Sens * -1; //get change in mouse vertically
        MouseY = Mathf.Clamp(MouseY,-90f,90f); // limit rotation vertically
        transform.localEulerAngles = new Vector3(MouseY,MouseX,0); //update camera rotation
    }
}

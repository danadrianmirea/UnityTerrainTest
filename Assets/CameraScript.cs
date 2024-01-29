using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform target;
    private Vector3 offset;// = new Vector3(0, 5, -10);
    private Vector3 rotationOffset;


    private float turnSpeed = 0.125f;

    // camera is a child of the player gameobject now so, for now, this script does nothing
    // will update it at some point maybe to to some fancy juicy stuff using smooth, lerp, etc
    // and maybe turn it more into a 3rd person look around camera 

    // Use this for initialization
    void Start () {
		//offset = transform.position - target.position;
        //rotationOffset = transform.rotation;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        //transform.position = target.position + offset;
        //transform.rotation = Quaternion.Euler(transform.eulerAngles.x, target.eulerAngles.y, transform.eulerAngles.z);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, turnSpeed); //target.rotation; //Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * turnSpeed);
        //transform.LookAt(target);


        //Vector3 desiredPosition = target.position + target.rotation * offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, turnSpeed);
        //transform.position = target.position + offset;

        //Quaternion desiredrotation = target.rotation * Quaternion.Euler(rotationOffset);
        //Quaternion smoothedrotation = Quaternion.Lerp(transform.rotation, desiredrotation, turnSpeed);
        //transform.rotation = smoothedrotation;
    }
}

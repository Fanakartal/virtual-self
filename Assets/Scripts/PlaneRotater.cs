using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotater : MonoBehaviour {

    public float speed = 10F;
    public Vector3 turningValues;
    public GameObject turningObject;

    // Use this for initialization
    void Start ()
    {
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(90, 0, 0), speed * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(turningValues), speed * Time.deltaTime);
        //transform.RotateAround()
    }
}

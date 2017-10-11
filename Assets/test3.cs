using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour {
	Rigidbody rb;
	public GameObject Nose;
	public GameObject rightW;
	public GameObject leftW;

	public GameObject Propeller;
	public WheelCollider frontR;
	public WheelCollider frontL;
	public WheelCollider back;
	public float power = 0f;
	public float rotationAngle = 0f;
	public float liftPower = 0f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//Propeller.transform.position = rb.centerOfMass;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("Center Of Mass :  "+ rb.centerOfMass);
		rotationAngle = Nose.transform.rotation.x;
		//liftPower = 0; //-Mathf.Sin (Nose.transform.rotation.x) * 100 ;
		if (Input.GetKey (KeyCode.T)) {
			power += 100;
		}
		if (Input.GetKey (KeyCode.R)) {
			power -= 100;
		}
		if (Input.GetKey (KeyCode.J)) {
			
			Nose.transform.Rotate (new Vector3 (-0.6f, 0, 0));
		}
		if (Input.GetKey (KeyCode.P)) {
			liftPower += 100;			
		}
		if (rb.velocity.magnitude > 40) {
			
			rb.AddForce (new Vector3 (0, liftPower, liftPower*5));
			//rb.AddForceAtPosition (new Vector3 (0, liftPower,liftPower*5), rightW.transform.position);
			//rb.AddForceAtPosition (new Vector3 (0, liftPower,liftPower*5), leftW.transform.position);
			if (liftPower > 7000) {
				rb.centerOfMass = new Vector3 (rb.centerOfMass.x, rb.centerOfMass.y, -2.7f);
			}
		} else {
			rb.AddForceAtPosition (new Vector3 (0, liftPower, power*7), Nose.transform.position);
		}

		//Debug.Log ("Lift Power:" + liftPower);
		frontR.motorTorque = Input.GetAxis("Vertical") * 8000;
		frontL.motorTorque = Input.GetAxis("Vertical") * 8000;
		back.steerAngle=Input.GetAxis("Horizontal") *  10;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour {
	Rigidbody rb;
	public GameObject centerOfMass;
	public GameObject Nose;
	public WheelCollider Front;
	public WheelCollider Left;
	public WheelCollider Right;
	public float zet;
	public float power = 0f;
	public float liftPower = 0f;

	//public WheelCollider back;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Debug.Log (rb.centerOfMass);
		rb.centerOfMass = centerOfMass.transform.localPosition;
		Debug.Log (rb.centerOfMass);
		zet = rb.centerOfMass.z;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (transform.rotation.x);
		if (Input.GetKey (KeyCode.T)) {
			power += 100;
		}
		if (Input.GetKey (KeyCode.P)) {
			liftPower += 50;

		}
		if (rb.velocity.magnitude > 40) {
			//rb.AddForceAtPosition (new Vector3(0, 4000, 7000),Nose.transform.position);
			rb.centerOfMass = new Vector3(-2.5f,rb.centerOfMass.y,-2f);
			rb.AddForce (Vector3.up * 14000);

		}
		if (transform.rotation.x < -0.15) {
			//rb.centerOfMass = new Vector3(rb.centerOfMass.x,rb.centerOfMass.y,-1.6f);

		}
	
		rb.AddForce (Vector3.forward * power * 5);
		Left.motorTorque = Input.GetAxis ("Vertical") * 80;
		Right.motorTorque = Input.GetAxis ("Vertical") * 80;
		Front.steerAngle = Input.GetAxis ("Horizontal") * 10;
	}
}

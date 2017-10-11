using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {
	Rigidbody rb;
	public GameObject Nose;
	public WheelCollider frontR;
	public WheelCollider frontL;
	public WheelCollider back;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		Debug.Log (rb.velocity.magnitude);
		if (Input.GetKey (KeyCode.J)) {
			rb.AddForceAtPosition (new Vector3(0,4000,3000),Nose.transform.position,ForceMode.Force);
			//rb.AddForce (new Vector3 (-5000, 0, -4000));
		}
		if (rb.velocity.magnitude > 40) {
			rb.AddForce (new Vector3 (0, 8500,0),ForceMode.Force);
			rb.AddForceAtPosition (new Vector3 (0, 3500, 35500), Nose.transform.position, ForceMode.Force);
		}
		if (rb.velocity.magnitude > 70) {
			//rb.AddForce(new Vector3 (0, -1500, -17500));

		}
		//Debug.Log (Input.GetAxis ("Horizontal"));
		if (Input.GetKey (KeyCode.T)) {
			rb.AddForce (new Vector3 (0, 0, 10000));
		}
		frontR.motorTorque = Input.GetAxis("Vertical") * 8000;
		frontL.motorTorque = Input.GetAxis("Vertical") * 8000;
		back.steerAngle=Input.GetAxis("Horizontal") *  10;

	}
}

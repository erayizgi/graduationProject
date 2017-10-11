using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour {
	Rigidbody rb;
	public GameObject Nose;
	//public GameObject centerOfMass;
	//public GameObject rear;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Debug.Log (rb.centerOfMass);
		rb.centerOfMass = new Vector3(2f,1.7f,0.1f);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.J)) {
			rb.AddForceAtPosition (new Vector3 (300, 400, 0),Nose.transform.position);
			//rb.AddForce (new Vector3 (300, 400, 0));

		}
		rb.velocity = new Vector3 (10, 0, 0);
		//if (Input.GetKey (KeyCode.W)) {
		//rb.AddForceAtPosition (new Vector3 (50, 0, 0),rear.transform.position,ForceMode.Acceleration);
		//	rb.AddForce(new Vector3(8,0,0),ForceMode.Acceleration);
		//}
		Debug.Log (rb.centerOfMass);
	}
}

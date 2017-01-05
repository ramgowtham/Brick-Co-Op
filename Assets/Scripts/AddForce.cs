using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {
	Rigidbody rb;
	public float degree;
	public float multiplier;

	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.anyKeyDown) {
			Debug.Log ("ok");
			rb.AddTorque (new Vector3(0,0,degree) * multiplier);
		}

	}
}

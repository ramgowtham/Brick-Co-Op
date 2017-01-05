using UnityEngine;
using System.Collections;

public class PadMovement : MonoBehaviour {
    float distance;
    public float speed;
    public float returnSpeed;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
    Quaternion target1 = Quaternion.Euler(20, 90, 0);
    Quaternion target2 = Quaternion.Euler(-30, 90, 0);
	Quaternion target3 = Quaternion.Euler(-30, -90, 0);
    // Update is called once per frame
    void Update () {



        distance = speed * Time.deltaTime * Input.GetAxis("J1LeftPad");
        if(this.gameObject.name== "LPad")
		{
			if(Input.GetAxis("J1LeftPad") > 0)
				transform.Rotate(Vector3.right * distance);
		else
			transform.rotation = Quaternion.Slerp(transform.rotation, target3, Time.deltaTime * returnSpeed);
		}



        distance = speed * Time.deltaTime * Input.GetAxis("J1RightPad");
        if (this.gameObject.name=="RPad")
        {
            if (Input.GetAxis("J1RightPad") > 0)
            {
                transform.Rotate(Vector3.right * 10);
                //transform.rotation = Quaternion.Slerp(transform.rotation, target1, Time.deltaTime * speed);
                rb.AddTorque(transform.right * 10);
            }
            else
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-30,90,0), Time.deltaTime * returnSpeed);
        }

    }
}

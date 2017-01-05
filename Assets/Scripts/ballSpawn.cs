using UnityEngine;
using System.Collections;

public class ballSpawn : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
            Instantiate(ball, transform.position, Quaternion.identity);
	}
}

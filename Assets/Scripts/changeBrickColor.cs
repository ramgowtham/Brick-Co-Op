using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBrickColor : MonoBehaviour {

    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;


    int x;


    // Use this for initialization
    void Start () {
        InvokeRepeating("ChangeColor", 0, 2);
    }
	
	// Update is called once per frame
	void Update () {


    }
   

    void ChangeColor()
    {
        x = Random.Range(1, 4);
        if (x == 1)
            gameObject.GetComponent<Renderer>().material = mat1;
        if (x == 2)
            gameObject.GetComponent<Renderer>().material = mat2;
        if (x == 3)
            gameObject.GetComponent<Renderer>().material = mat3;
        if (x == 4)
            gameObject.GetComponent<Renderer>().material = mat4;

     

    }



}

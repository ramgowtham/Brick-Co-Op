using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeJointTest : MonoBehaviour {

    public float restPosition=0f;
    public float pressedPosition=45f;
    public float flipperStrength=10f;
    public float flipperDamper=1f;



    private void Awake()
    {
        GetComponent<HingeJoint>().useSpring = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        JointSpring spring = new JointSpring();

        spring.spring = flipperStrength;
        spring.damper = flipperDamper;

        if(Input.GetKey(KeyCode.Space))
            spring.targetPosition = pressedPosition;
	    else
		    spring.targetPosition = restPosition;

        

        GetComponent< HingeJoint > ().spring = spring;
        GetComponent< HingeJoint > ().useLimits = true;

      

        //GetComponent< HingeJoint > ().limits.min = restPosition;
        //GetComponent< HingeJoint > ().limits.max = pressedPosition;

    }
}

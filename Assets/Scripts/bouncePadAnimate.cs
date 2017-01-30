using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncePadAnimate : MonoBehaviour {
  

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="ball")
        {
            GetComponent<Animator>().Play("BounceAnimation");
        }
    }

}

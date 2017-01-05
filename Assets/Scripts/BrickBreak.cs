using UnityEngine;
using System.Collections;

public class BrickBreak : MonoBehaviour {

    int NoOfHits;



	// Use this for initialization
	void Start () {
        NoOfHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "ball")
        {
            if (NoOfHits == 0)
            {
                NoOfHits = 1;
                gameObject.GetComponent<Renderer>().material.color = Color.gray;
                
            }
            else
                if (NoOfHits == 1)
                {
                Destroy(this.gameObject);
                }
        }         

    }
}

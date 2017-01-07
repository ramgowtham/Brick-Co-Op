using UnityEngine;
using System.Collections;

public class BrickBreak : MonoBehaviour {

    int NoOfHits;

    Color color;

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
               
                color.r = .6f;
                color.g = .6f;
                color.b = 0.6f;

                

                // gameObject.GetComponent<Renderer>().material.color = Color.gray;
                this.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);


            }
            else
                if (NoOfHits == 1)
                {
                Destroy(this.gameObject);
                }
        }         

    }
}

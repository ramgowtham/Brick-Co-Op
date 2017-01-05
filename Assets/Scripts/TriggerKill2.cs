using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class TriggerKill2 : MonoBehaviour {
    public Text txt;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider coll)
    {
  
        ScoreManager.Player2Score += 1;
        txt.text = "" + ScoreManager.Player2Score;
        Destroy(coll.gameObject);
    }
}

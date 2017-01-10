using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
    Rigidbody rb;

   
    public float PlayerPadBounce;
    public float BouncePadBounce;
    public float BrickBounce;
    public float NormalWallBounce;

    public float MaxSpeed = 100f;

    public ParticleSystem hitParticle;

    
    
    
    
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.down * PlayerPadBounce;
	}





    private void OnGUI()
    {
        GUIStyle guistyle = new GUIStyle();
        guistyle.fontSize = 30;
        
        GUILayout.Label(""+ rb.velocity.magnitude, guistyle);
    }





    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > MaxSpeed)
            rb.velocity = rb.velocity.normalized * MaxSpeed;
    }





    float hitFactor(Vector2 ballPos, Vector2 PadPosition, float PadLength)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.x - PadPosition.x) / PadLength;

    }



        void OnCollisionEnter(Collision col)
    {



        hitParticle.GetComponent<Renderer>().material = col.gameObject.GetComponent<Renderer>().material;
        Instantiate(hitParticle, transform.position, Quaternion.identity);

  




        if (col.gameObject.layer == 8)
        {
         

            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, 0.5f).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody>().velocity = dir * BouncePadBounce;
        }




        if (col.gameObject.layer == 9)
        {
        

            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, 0.5f).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody>().velocity = dir * BrickBounce;
        }


        if (col.gameObject.layer == 11)
        {
            

            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, 0.5f).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody>().velocity = dir * NormalWallBounce;
        }





        if (col.gameObject.layer == 10)
        {
           
      
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, 0.5f).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody>().velocity = dir * PlayerPadBounce;
        }

    }



}

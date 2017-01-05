using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour
{

    Rigidbody rb;
    public float speed;

    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.gameObject.name == "Player2mode1")
        {
            float horizontalInput = Input.GetAxisRaw("Player_2_Horizontal");
            Vector3 move = new Vector3(horizontalInput, 0, 0);
            rb.velocity = move * speed;
        }

        if (this.gameObject.name == "Player2mode2")
        {

            float rightRotate = Input.GetAxisRaw("J2RightPad");
            transform.Rotate(new Vector3(0, 0, 1)*rightRotate * rotationSpeed * Time.deltaTime);

            float leftRotate = Input.GetAxisRaw("J2LeftPad");
            transform.Rotate(new Vector3(0, 0, 1)*leftRotate * -rotationSpeed * Time.deltaTime);
            
        }

        


    }
}
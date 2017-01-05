using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour
{


    Rigidbody rb;
    public float Movementspeed;

    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }




    // Update is called once per frame
    void FixedUpdate()
    {
              if (this.gameObject.name == "Player1mode1")
               {
                   float horizontalInput = Input.GetAxisRaw("Player_1_Horizontal");
                   Vector3 move = new Vector3(horizontalInput, 0, 0);
                   rb.velocity = move * Movementspeed;
               }


               if (this.gameObject.name == "Player1mode2")
               {
                   
                float rightRotate = Input.GetAxisRaw("J1RightPad");  
                transform.Rotate(new Vector3(0, 0, 1)*rightRotate * rotationSpeed*Time.deltaTime);

                float leftRotate = Input.GetAxisRaw("J1LeftPad");
                transform.Rotate(new Vector3(0, 0, 1)*leftRotate * -rotationSpeed * Time.deltaTime);
                   
               }

       



    }

}
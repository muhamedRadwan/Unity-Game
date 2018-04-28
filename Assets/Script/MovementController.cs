using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;



public class MovementController : MonoBehaviour {

	public bool isGrounded;
	private float speed;
	public float rotSpeed;
	public float jumpHeight;
	//walk speed
	private float w_speed = 0.05f;
	//rotation speed
	private float rot_speed = 1.0f;
	Rigidbody rb;
	Animator anim;

	void Start () {
		rb = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
		isGrounded = true; //indicate that we are in the ground
	}

	// Update is called once per frame
	void Update() {
		if (isGrounded) {
			//moving forward and backward
			if (Input.GetKey (KeyCode.UpArrow)) {
				speed = w_speed;
				movementControl ("WalkingForward");
			   }
			      else if (Input.GetKey(KeyCode.DownArrow))
			      {
				    speed = w_speed;
				    movementControl("WalkingBackward");
			      }
			else if (Input.GetKey (KeyCode.LeftShift)) {
				speed = 2f;
				movementControl("Running");
			     } 
			      else
			      {
			    	movementControl("idle");
			      }
			//moving right and left
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				rotSpeed = rot_speed;
			}
				
			    else if (Input.GetKey(KeyCode.RightArrow))
			    {
				  rotSpeed = rot_speed;
			    }
			    else
			    {
				  rotSpeed = 0;
			    }
			var z = Input.GetAxis("Vertical") * speed;
			var y = Input.GetAxis("Horizontal") * rotSpeed;
			transform.Translate(0, 0, z);
			transform.Rotate(0, y, 0);

			if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
			{
				anim.SetTrigger("isJumping");
				rb.AddForce(0, jumpHeight * Time.deltaTime, 0);

			}



		}
		}

		//jumping function



	void movementControl(string state)
	{
		switch (state)
		{
		case "WalkingForward":
			anim.SetBool("isWalkingForward", true);
			anim.SetBool("isWalkingBackward", false);
			anim.SetBool("isIdle", false);
			anim.SetBool ("isRunning", false);
			break;
		case "WalkingBackward":
			anim.SetBool("isWalkingForward", false);
			anim.SetBool("isWalkingBackward", true);
			anim.SetBool("isIdle", false);
			anim.SetBool ("isRunning", false);
			break;
		case "idle":
			anim.SetBool("isWalkingForward", false);
			anim.SetBool("isWalkingBackward", false);
			anim.SetBool("isIdle", true);
			anim.SetBool ("isRunning", false);
			break;
		case "Jumping":
			anim.SetBool ("isWalkingForward", false);
			anim.SetBool ("isWalkingBackward", false);
			anim.SetBool ("isIdle", false);
			anim.SetTrigger ("isJumping");
			anim.SetBool ("isRunning", false);
			break;
		case "Running":
			anim.SetBool ("isWalkingForward", false);
			anim.SetBool ("isWalkingBackward", false);
			anim.SetBool ("isIdle", false);
			anim.SetBool ("isRunning", true);
			break;
		}
	}
}


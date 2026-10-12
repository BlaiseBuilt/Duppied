using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerMove : MonoBehaviour
{
  private const bool V = true;
  InputAction jumpAction, crouchAction, moveLeftAction, moveRightAction;
  Rigidbody rigidbody;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    rigidbody = this.GetComponent<Rigidbody>();
    moveLeftAction = InputSystem.actions.FindAction("Move Left");
    moveRightAction = InputSystem.actions.FindAction("Move Right");
    jumpAction = InputSystem.actions.FindAction("Jump");
    crouchAction = InputSystem.actions.FindAction("Crouch");
  }

  //FixedUpdate is called every fixed framerate frame
  void Update()
  {
    CrouchCheck();
  }

//FixedUpdate is called every fixed framerate frame. Used to handle physics calculations 
//and movement.
  void FixedUpdate()
  {
    MoverRight();
    MoveLeft();
    JumpCheck();
  }

  //Checks if the player is moving right and moves the player accordingly.
  void MoverRight()
  {
    if (moveRightAction.IsPressed())
    {
      this.transform.position += new Vector3(0.05f, 0, 0);
    }
  }

//Checks if the player is moving left and moves the player accordingly.
  void MoveLeft()
  {
    if (moveLeftAction.IsPressed())
    {
      this.transform.position += new Vector3(-0.05f, 0, 0);
    }
  }

  //Checks if the player is jumping
  void JumpCheck()
  {
    if (jumpAction.IsPressed() && IsGrounded())
    {
      rigidbody.AddForce(transform.up * 500f, ForceMode.Force);
      Debug.Log("Jumping Firing");
    }
  }

  //Player crouches when the crouch button is pressed and returns to normal size when the button is released.
  void CrouchCheck()
  {
    if (crouchAction.IsPressed())
    {
      this.transform.localScale = new Vector3(1, 0.5f, 1);
    }
    else
    {
      this.transform.localScale = new Vector3(1, 1, 1);
    }
  }

//Checks if the player is grounded
  bool IsGrounded()
  {
    if (this.transform.position.y <= 0.5f)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

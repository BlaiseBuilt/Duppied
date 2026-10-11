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

  void FixedUpdate()
  {
    MoverRight();
    MoveLeft();
    JumpCheck();
  }

  //Checks the direction of movement and logs a message accordingly.
  void MoverRight()
  {
    if (moveRightAction.IsPressed())
    {
      this.transform.position += new Vector3(0.05f, 0, 0);
    }
  }

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

  //Checks if the player is crouching
  void CrouchCheck()
  {
    if (crouchAction.WasPressedThisFrame())
    {
      Debug.Log("Crouching");
    }
  }

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

using UnityEngine;
using UnityEngine.InputSystem;

public class TestScripts : MonoBehaviour
{
  InputAction jumpAction, crouchAction, moveLeftAction, moveRightAction;
  int frameWindow = 60;
  int lastMoveFrame;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    moveLeftAction = InputSystem.actions.FindAction("Move Left");
    moveRightAction = InputSystem.actions.FindAction("Move Right");
    jumpAction = InputSystem.actions.FindAction("Jump");
    crouchAction = InputSystem.actions.FindAction("Crouch");
  }

  //FixedUpdate is called every fixed framerate frame
  void Update()
  {
    JumpCheck();
    CrouchCheck();
  }

  void FixedUpdate()
  {
    MoverRight();
    MoveLeft();
  }

  //Checks the direction of movement and logs a message accordingly.
  void MoverRight()
  {
    if (moveRightAction.IsPressed())
    {
      this.transform.position += new Vector3(0.5f, 0, 0);
    }
  }


  void MoveLeft()
  {
    if (moveLeftAction.IsPressed())
    {
      this.transform.position += new Vector3(-0.5f, 0, 0);
    }
  }

  //Checks if the player is jumping
  void JumpCheck()
  {
    if (jumpAction.WasPressedThisFrame())
    {
      Debug.Log("Jumping");
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
}

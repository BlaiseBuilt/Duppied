using UnityEngine;
using UnityEngine.InputSystem;

public class TestScripts : MonoBehaviour
{
  InputAction moveAction, jumpAction, crouchAction, moveLeftAction, moveRightAction;
  int frameWindow = 30;
  int lastMoveFrame = -1;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    moveAction = InputSystem.actions.FindAction("Move");
    moveLeftAction = InputSystem.actions.FindAction("Move Left");
    moveRightAction = InputSystem.actions.FindAction("Move Right");
    jumpAction = InputSystem.actions.FindAction("Jump");
    crouchAction = InputSystem.actions.FindAction("Crouch");
  }

  //FixedUpdate is called every fixed framerate frame
  void FixedUpdate()
  {
    MoverRight();
    MoveLeft();
    JumpCheck();
    CrouchCheck();
  }

  void Update()
  {
    Dash();
  }

  //Checks if the move action was performed twice within the frame window and returns true or false.
  bool DashCheck()
  {
    if (MoverRight() || MoveLeft())
    {
      int currentFrame = Time.frameCount;
      if (lastMoveFrame >= 0 && currentFrame - lastMoveFrame <= frameWindow)
      {
        lastMoveFrame = -1;
        return true;
      }
      lastMoveFrame = currentFrame;
    }
    return false;
  }

  void Dash()
  {
    if (DashCheck())
    {
      Debug.Log("Dashing");
    }
  }

  //Checks the direction of movement and logs a message accordingly.
  bool MoverRight()
  {
    if (moveRightAction.WasPressedThisFrame())
    {
      Debug.Log("Moving Right");
      return true;
    }
    return false;
  }
  

  bool MoveLeft()
  {
    if (moveLeftAction.WasPressedThisFrame())
    {
      Debug.Log("Moving Left");
      return true;
    }
    return false;
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

using UnityEngine;
using UnityEngine.InputSystem;

public class TestScripts : MonoBehaviour
{
  InputAction moveAction, jumpAction, crouchAction;
  int frameWindow = 30;
  int lastMoveFrame = -1;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    moveAction = InputSystem.actions.FindAction("Move");
  }

  //FixedUpdate is called every fixed framerate frame
  void FixedUpdate()
  {
    TestMove();
    if (DashCheck())
    {
      Debug.Log("Dash Detected");
    }
    ForwardCheck();
    JumpCheck();
    CrouchCheck();
  }

  //Checks if the move action was pressed this frame and logs a message if it was.
  private void TestMove()
  {
    if (moveAction.WasPressedThisFrame())
    {
      Debug.Log("Movement Initialized");
    }
  }

  //Checks if the move action was performed twice within the frame window and returns true or false.
  bool DashCheck()
  {
    if (moveAction.WasPerformedThisFrame())
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

  //Checks the direction of movement and logs a message accordingly.
  void ForwardCheck()
  {
    if (moveAction.ReadValue<Vector2>().x > 0)
    {
      Debug.Log("Moving Forward");
    }
    if (moveAction.ReadValue<Vector2>().x < 0)
    {
      Debug.Log("Moving Backward");
    }
  }

  //Checks if the player is jumping
  void JumpCheck()
  {
    if (moveAction.ReadValue<Vector2>().y > 0)
    {
      Debug.Log("Jumping");
    }
  }

  //Checks if the player is crouching
  void CrouchCheck()
  {
    if (moveAction.ReadValue<Vector2>().y < 0)
    {
      Debug.Log("Crouching");
    }
  }
}

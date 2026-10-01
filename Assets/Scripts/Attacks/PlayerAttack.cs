using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
  InputAction lightPunchAction, mediumPunchAction, heavyPunchAction,
    lightKickAction, mediumKickAction, heavyKickAction;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    lightPunchAction = InputSystem.actions.FindAction("LightPunch");
    mediumPunchAction = InputSystem.actions.FindAction("MediumPunch");
    heavyPunchAction = InputSystem.actions.FindAction("HeavyPunch");
    lightKickAction = InputSystem.actions.FindAction("LightKick");
    mediumKickAction = InputSystem.actions.FindAction("MediumKick");
    heavyKickAction = InputSystem.actions.FindAction("HeavyKick");
  }

  //FixedUpdate is called every fixed framerate frame
  void FixedUpdate()
  {
    lightPunchCheck();
    mediumPunchCheck();
    heavyPunchCheck();
    lightKickCheck();
    mediumKickCheck();
    heavyKickCheck();
    grabCheck();
  }

  void lightPunchCheck()
  {
    if (lightPunchAction.WasPressedThisFrame())
    {
      Debug.Log("Light Punch");
    }
  }

  void mediumPunchCheck()
  {
    if (mediumPunchAction.WasPressedThisFrame())
    {
      Debug.Log("Medium Punch");
    }
  }

  void heavyPunchCheck()
  {
    if (heavyPunchAction.WasPressedThisFrame())
    {
      Debug.Log("Heavy Punch");
    }
  }

  void lightKickCheck()
  {
    if (lightKickAction.WasPressedThisFrame())
    {
      Debug.Log("Light Kick");
    }
  }

  void mediumKickCheck()
  {
    if (mediumKickAction.WasPressedThisFrame())
    {
      Debug.Log("Medium Kick");
    }
  }

  void heavyKickCheck()
  {
    if (heavyKickAction.WasPressedThisFrame())
    {
      Debug.Log("Heavy Kick");
    }
  }

  void grabCheck()
  {
    if (lightKickAction.WasPressedThisFrame() && lightPunchAction.WasPressedThisFrame())
    {
      Debug.Log("Grab");
    }
  }

}

using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
  InputAction lightPunchAction, mediumPunchAction, heavyPunchAction,
    lightKickAction, mediumKickAction, heavyKickAction;

  public event Action LightKickPressed, MediumKickPressed, HeavyKickPressed,
                      LightPunchPressed, MediumPunchPressed, HeavyPunchPressed,
                      ThrowPressed;

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
  void Update()
  {
    lightPunchCheck();
    mediumPunchCheck();
    heavyPunchCheck();
    lightKickCheck();
    mediumKickCheck();
    heavyKickCheck();
    throwCheck();
  }

  void lightPunchCheck()
  {
    if (lightPunchAction.WasPressedThisFrame())
    {
      LightPunchPressed?.Invoke();
    }
  }

  void mediumPunchCheck()
  {
    if (mediumPunchAction.WasPressedThisFrame())
    {
      MediumPunchPressed?.Invoke();
    }
  }

  void heavyPunchCheck()
  {
    if (heavyPunchAction.WasPressedThisFrame())
    {
      HeavyPunchPressed?.Invoke();
    }
  }

  void lightKickCheck()
  {
    if (lightKickAction.WasPressedThisFrame())
    {
      LightKickPressed?.Invoke();
    }
  }

  void mediumKickCheck()
  {
    if (mediumKickAction.WasPressedThisFrame())
    {
      MediumKickPressed?.Invoke();
    }
  }

  void heavyKickCheck()
  {
    if (heavyKickAction.WasPressedThisFrame())
    {
      HeavyKickPressed?.Invoke();
    }
  }

  void throwCheck()
  {
    if (lightPunchAction.WasPressedThisFrame() && lightKickAction.WasPressedThisFrame())
    {
      ThrowPressed?.Invoke();
    }
  }
}

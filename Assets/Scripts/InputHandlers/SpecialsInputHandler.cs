using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpecialsInputHandler : MonoBehaviour
{
    private PlayerAttack playerAttack; // Reference to the PlayerAttack component
    private NewPlayerMove newPlayerMove; // Reference to the NewPlayerMove component

    private int inputWindow = 10; // Number of frames to check for input

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAttack = GetComponent<PlayerAttack>();
        newPlayerMove = GetComponent<NewPlayerMove>();
    }

    void OnEnable()
    {
       newPlayerMove.CrouchPressed += HandleCrouchPressed;
    }

    void OnDisable()
    {
        newPlayerMove.CrouchPressed -= HandleCrouchPressed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandleCrouchPressed()
    {
        
    }

    void QuarterCircleForward()
    {
        if(newPlayerMove.CrouchPressed)
        {
        }
    }
}

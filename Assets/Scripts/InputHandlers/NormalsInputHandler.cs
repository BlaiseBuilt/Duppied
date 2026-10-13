using UnityEngine;
using UnityEngine.InputSystem; 

public class NormalsInputHandler : MonoBehaviour
{
    private PlayerAttack playerAttack;
    private NewPlayerMove newPlayerMove;

    void Awake()
    {
        playerAttack = GetComponent<PlayerAttack>();
        newPlayerMove = GetComponent<NewPlayerMove>();
    }

    void OnEnable()
    {
        playerAttack.LightKickPressed += HandleLightKickPressed;
    }

    void OnDisable()
    {
        playerAttack.LightKickPressed -= HandleLightKickPressed;
    }

    private void HandleLightKickPressed()
    {
        if (newPlayerMove !=null && newPlayerMove.IsCrouching)
        {
            CrouchingLightKick();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrouchingLightKick()
    {
        Debug.Log("Crouching Light Kick");
    }
}

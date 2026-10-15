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
        //playerAttack.LightPunchPressed += HandleLightPunchPressed;
        //playerAttack.MediumPunchPressed += HandleMediumPunchPressed;
        //playerAttack.HeavyPunchPressed += HandleHeavyPunchPressed;
        playerAttack.LightKickPressed += HandleLightKickPressed;
        //playerAttack.MediumKickPressed += HandleMediumKickPressed;
        //playerAttack.HeavyKickPressed += HandleHeavyKickPressed;
    }

    void OnDisable()
    {
        playerAttack.LightKickPressed -= HandleLightKickPressed;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when the Light Kick input is pressed
    private void HandleLightKickPressed()
    {
        if (newPlayerMove.IsCrouching && newPlayerMove.GroundCheck())
        {
            // Perform crouching light kick action
            Debug.Log("Crouching Light Kick!");
        }
        else if (!newPlayerMove.GroundCheck())
        {
            // Perform jumping light kick action
            Debug.Log("Jumping Light Kick!");
        }
        else if (!newPlayerMove.IsCrouching && newPlayerMove.GroundCheck())
        {
            // Perform standing light kick action
            Debug.Log("Standing Light Kick!");
        }
    }
}

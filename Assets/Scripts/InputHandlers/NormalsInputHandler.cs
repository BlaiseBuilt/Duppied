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

    // This method is called when the Medium Kick input is pressed
    private void HandleMediumKickPressed()
    {
        if (newPlayerMove.IsCrouching && newPlayerMove.GroundCheck())
        {
            // Perform crouching medium kick action
            Debug.Log("Crouching Medium Kick!");
        }
        else if (!newPlayerMove.GroundCheck())
        {
            // Perform jumping medium kick action
            Debug.Log("Jumping Medium Kick!");
        }
        else if (!newPlayerMove.IsCrouching && newPlayerMove.GroundCheck())
        {
            // Perform standing medium kick action
            Debug.Log("Standing Medium Kick!");
        }
    }

    // This method is called when the Heavy Kick input is pressed
    private void HandleHeavyKickPressed()
    {
        if (newPlayerMove.IsCrouching && newPlayerMove.GroundCheck())
        {
            // Perform crouching heavy kick action
            Debug.Log("Crouching Heavy Kick!");
        }
        else if (!newPlayerMove.GroundCheck())
        {
            // Perform jumping heavy kick action
            Debug.Log("Jumping Heavy Kick!");
        }
        else if (!newPlayerMove.IsCrouching && newPlayerMove.GroundCheck())
        {
            // Perform standing heavy kick action
            Debug.Log("Standing Heavy Kick!");
        }
    }
}

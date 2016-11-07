using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MobileInputScript : MonoBehaviour
{

    private PlayerMovementScript player;
    private GameManagerScript gameManager;

    public InputCommand type;

    private bool isLeftActivated;
    private bool isRightActivated;

    // Use this for initialization
    void Start()
    {
        EventTrigger trigger = GetComponent<EventTrigger>();
        
        EventTrigger.Entry pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = EventTriggerType.PointerDown;
        pointerDown.callback.AddListener((data) =>
        {
            OnPointerDown();
        });
        trigger.triggers.Add(pointerDown);

        EventTrigger.Entry pointerUp = new EventTrigger.Entry();
        pointerUp.eventID = EventTriggerType.PointerUp;
        pointerUp.callback.AddListener((data) =>
        {
            OnPointerUp();
        });
        trigger.triggers.Add(pointerUp);

        player = GameObject.FindWithTag("Player").GetComponent<PlayerMovementScript>();
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLeftActivated)
            player.MoveLeft();
        if (isRightActivated)
            player.MoveRight();
    }

    void OnPointerDown()
    {
        switch (type)
        {
            case InputCommand.LEFT:
                isLeftActivated = true;
                break;
            case InputCommand.RIGHT:
                isRightActivated = true;
                break;
            case InputCommand.JUMP:
                player.Jump();
                break;
            case InputCommand.MENU:
                gameManager.isPaused = !gameManager.isPaused;
                break;
            default:
                break;
        }
    }

    void OnPointerUp()
    {
        switch (type)
        {
            case InputCommand.LEFT:
                isLeftActivated = false;
                break;
            case InputCommand.RIGHT:
                isRightActivated = false;
                break;
            default:
                break;
        }
    }

    public enum InputCommand
    {
        LEFT,
        RIGHT,
        JUMP,
        MENU
    }
}

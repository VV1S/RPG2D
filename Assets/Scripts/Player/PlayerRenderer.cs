using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRenderer : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] SpriteRenderer spriteRenderer;

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 movementInput = value.ReadValue<Vector2>();

        if (movementInput.x > 0 && PlayerIsLookingLeft()) 
        {
            spriteRenderer.flipX = false;
        }
        else if (movementInput.x < 0 && !PlayerIsLookingLeft())
        {
            spriteRenderer.flipX = true;
        }
    }

    private bool PlayerIsLookingLeft()
    {
        return spriteRenderer.flipX;
    }
}

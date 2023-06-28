using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] Animator animator;
    
    public void OnMovement(InputAction.CallbackContext value)
    {
        var movementInput = value.ReadValue<Vector2>().magnitude;

        animator.SetBool("isRunning", movementInput != 0);
    }
}

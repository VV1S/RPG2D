using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] float speed;

    [Header("Dependencies")]
    [SerializeField] Rigidbody2D rigidbody;

    Vector2 _movementInput;

    private void FixedUpdate()
    {
        rigidbody.velocity = _movementInput * speed;
    }

    public void OnMovement(InputAction.CallbackContext value) 
    {
        _movementInput = value.ReadValue<Vector2>();
    }
}

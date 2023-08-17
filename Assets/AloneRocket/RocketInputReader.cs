using UnityEngine;
using UnityEngine.InputSystem;

public class RocketInputReader : MonoBehaviour
{
    [SerializeField] private Rocket _rocket;
    public void OnFly(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        _rocket.SetDirectoin(direction);
    }
}

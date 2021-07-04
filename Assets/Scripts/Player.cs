using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public Camera camera;

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        transform.position += 10 * Time.deltaTime * new Vector3(input.x, 0, input.y);
    }


    public void Camera(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        camera.transform.position += 10 * Time.deltaTime * new Vector3(input.x, 0, input.y);
    }
}

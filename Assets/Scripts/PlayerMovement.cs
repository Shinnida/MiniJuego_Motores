using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 moveInput;

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal"); 
        moveInput.y = Input.GetAxisRaw("Vertical"); 

        moveInput = moveInput.normalized;
        transform.Translate(moveInput * speed * Time.deltaTime);
    }
}

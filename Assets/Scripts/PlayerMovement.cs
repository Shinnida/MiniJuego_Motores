using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;
    private Rigidbody2D rb;
    private SpriteRenderer playerRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput = moveInput.normalized;

        if (moveInput != Vector2.zero)
        {
            DoRaycast();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }

    void DoRaycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, moveInput, 5f);

        // Dibujar SIEMPRE el rayo (aunque no toque nada)
        Debug.DrawRay(transform.position, moveInput * 5f, Color.red);

        if (hit.collider != null)
        {
            GameObject obj = hit.collider.gameObject;

            Debug.Log(" Detectado: " + obj.name +
                      " | Posición: " + obj.transform.position +
                      " | Tag: " + obj.tag);

            if (obj.CompareTag("Shape"))
            {
                Sprite s = obj.GetComponent<SpriteRenderer>().sprite;
                Debug.Log("El jugador cambiaría su FORMA a: " + s.name);
            }
            else if (obj.CompareTag("Color"))
            {
                Color c = obj.GetComponent<SpriteRenderer>().color;
                Debug.Log("El jugador cambiaría su COLOR a: " + c);
            }
        }
    }
}


using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SpriteRenderer playerRenderer; 

    void Start()
    {
        playerRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shape"))
        {
            Sprite shapeSprite = other.GetComponent<SpriteRenderer>().sprite;
            playerRenderer.sprite = shapeSprite;

            Debug.Log("Cambiando FORMA → " + other.name);
        }

        if (other.CompareTag("Color"))
        {
            Color newColor = other.GetComponent<SpriteRenderer>().color;
            playerRenderer.color = newColor;

            Debug.Log("Cambiando COLOR → " + other.name);
        }
    }

}

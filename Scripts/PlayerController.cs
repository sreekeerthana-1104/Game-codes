using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}

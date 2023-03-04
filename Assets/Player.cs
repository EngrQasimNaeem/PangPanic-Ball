using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4f;

    public Rigidbody2D rb;

    private float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //horizontal speed is either -1 or 1 so if it's move to the right speed is 4 and for left -4
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate() 
    {
        //Actual moving of a character is in a fixed update because thats where unity wants to calculate physics
        rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
    }
}


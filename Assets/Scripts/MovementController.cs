using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public int speed;
    public Vector2 direction;
    public Rigidbody2D body;
    
    // Update is called once per frame
    void Update()
    {
        if (!body || body.isKinematic)
        {
            Move();
        }
    }

    void FixedUpdate()
    {
        if (body && !body.isKinematic)
        {
            MoveDynamic();
        }
    }
    
    void Move()
    {
        var position = transform.position;
        position += speed * Time.deltaTime * (Vector3)direction.normalized;
        transform.position = position;
    }

    void MoveDynamic()
    {
        body.velocity = direction.normalized * speed;
    }
    
    public void UpdateDirection(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }


}

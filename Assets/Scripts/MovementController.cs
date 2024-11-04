using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public int speed;
    public Vector2 direction;
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    void Move()
    {
        var position = transform.position;
        position += speed * Time.deltaTime * (Vector3)direction.normalized;
        transform.position = position;
    }
    
    public void UpdateDirection(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }


}

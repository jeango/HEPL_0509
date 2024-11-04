using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    public void Fire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}

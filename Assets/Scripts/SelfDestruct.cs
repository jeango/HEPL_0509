using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float delay;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Destroy(gameObject, delay);
    }

}

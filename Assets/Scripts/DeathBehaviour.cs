using UnityEngine;

public class DeathBehaviour : MonoBehaviour
{
    public int scoreOnDeath;

    public void Die()
    {
        GameManager.score += scoreOnDeath;
        Destroy(gameObject);    
    }
}

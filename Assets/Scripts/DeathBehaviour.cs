using UnityEngine;

public class DeathBehaviour : MonoBehaviour
{
    public int scoreOnDeath;
    
    void OnDestroy()
    {
        Die();
    }

    void Die()
    {
        GameManager.score += scoreOnDeath;
    }
}

using UnityEngine;

public class DeathBehaviour : MonoBehaviour
{
    public int scoreOnDeath;
    public GameObject deathEffect;

    public void Die()
    {
        GameManager.score += scoreOnDeath;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);    
    }
}

using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToDamage;
    public bool canKill;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToDamage.Contains(other.attachedRigidbody?.tag))
        {
            KillOrDestroy(other.attachedRigidbody.gameObject);
        }
    }

    private void KillOrDestroy(GameObject obj)
    {
        if (canKill)
        {
            var deathBh = obj.GetComponent<DeathBehaviour>();
            if (deathBh)
            {
                deathBh.Die();
                return;
            }
        }
        Destroy(obj);
    }
}

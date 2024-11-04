using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToDamage;
    //TODO: mettre en place les tags dans les prefabs
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tagsToDamage.Contains(other.attachedRigidbody?.tag))
        {
            Destroy(other.attachedRigidbody.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDealDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var healthComponent = other.GetComponent<Health>();
            if(healthComponent != null)
            {
                healthComponent.TakeDamage(10);
            }
        }
    }
}

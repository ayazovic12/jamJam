using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDealDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            var healthComponent = other.GetComponent<Health>();
            if(healthComponent != null)
            {
                healthComponent.TakeDamage(10);
            }
        }
    }
}

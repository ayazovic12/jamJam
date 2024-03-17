using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxhealth = 100f;
    public float health;

    void Start()
    {
        health = maxhealth;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "sword")
        {
            health -= 30f;
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

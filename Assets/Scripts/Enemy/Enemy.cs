using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    GameObject mainCharachterPos;
    Vector3 distanceBetween;
    float speed = 5;

    Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetween = (mainCharachterPos.transform.position - transform.position).normalized;
        enemyRb.AddForce(distanceBetween * speed );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    GameObject mainCharachterPos;
    Vector3 distanceBetween;
    float speed = 1;
    float rotationSpeed = 3f;

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
        transform.Rotate(distanceBetween);
        enemyRb.AddForce(distanceBetween * speed );
    }
}

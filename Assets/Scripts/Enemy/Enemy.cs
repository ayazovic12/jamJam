using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    GameObject mainCharachterPos;
    Vector3 moveDirection;
    float speed = 5f;

    Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(mainCharachterPos.transform.position, transform.position);
        Debug.Log(distance);
        float attackDistance = 2f;
        // Ýf distance bigger than attackDistance Movement keeps working
        if (distance > attackDistance)
        {
            Movement();
        }
        else if (distance <= attackDistance)
            Attack();


    }

    void Movement()
    {
        moveDirection = (mainCharachterPos.transform.position - transform.position);
        transform.LookAt(mainCharachterPos.transform);
        enemyRb.velocity = moveDirection.normalized * speed ;
    }


    void Attack()
    {
        Debug.Log("attacking");
    }
    
}

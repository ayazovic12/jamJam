using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private InputManager inputManager;
    private Animator animator;
    
    void Awake()
    {
        inputManager = GetComponent<InputManager>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        LightAttack();
        HeavyAttack();
    }

    void LightAttack()
    {
        if(inputManager.Attack1)
        {
            animator.SetTrigger("LightAttackTrigger");
            inputManager.Attack1 = false;
        }
    }

    void HeavyAttack()
    {
        if(inputManager.Attack2)
        {
            animator.SetTrigger("HeavyAttackTrigger");
            inputManager.Attack2 = false;
        }
    }
}
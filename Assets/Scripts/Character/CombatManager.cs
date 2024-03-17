using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private InputManager inputManager;
    
    void Awake()
    {
        inputManager = GetComponent<InputManager>();
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
            Debug.Log("Light Attack");
        }
    }

    void HeavyAttack()
    {
        if(inputManager.Attack2)
        {
            Debug.Log("Heavy Attack");
        }
    }
}

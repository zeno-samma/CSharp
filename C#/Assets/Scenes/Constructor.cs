using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Constructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy boss = new Boss(1);

    }
    public class Enemy
    {
        public float hp;
        public float damage;
        public float moveSpeed;

        public Enemy(float dmg)
        {
            Debug.Log("Cha");
        }

        public void Move()
        {

        }
    }
    public class Boss : Enemy
    {
        public Boss(float dmgCopy)  : base(dmgCopy)
        {
            Debug.Log("Con");
        }

    }
}

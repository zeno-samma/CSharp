using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy boss = new Boss();
        boss.Move();
    }

    public class Enemy//Cha
    {
        public int hp;

        public virtual void Move() 
        {
            Debug.Log("Move cua enemy");
        }
    }

    public class Boss: Enemy//Con ke thua
    {
        //public new void Move() //Neu dung new thi se truy cap vao phuong thuc cua cha
        public override void Move()//Neu dung override se ghi de len phuong thuc cha va chuong trinh se truy cap vao phuong thuc cua con
        {
            Debug.Log("Move cua Boss");
        }
    }
}

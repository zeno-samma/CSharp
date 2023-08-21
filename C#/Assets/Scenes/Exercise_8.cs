using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_8 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //Enemy boss = new Boss();
        //boss.Move();
        Animal animal = new Cat(1);
        
    }
    //========================Ly thuyet===============
    //public class Enemy//Cha
    //{
    //    public int hp;

    //    public virtual void Move()
    //    {
    //        Debug.Log("Move cua enemy");
    //    }
    //}

    //public class Boss : Enemy//Con ke thua
    //{
    //    //public new void Move() //Neu dung new thi se truy cap vao phuong thuc cua cha
    //    public override void Move()//Neu dung override se ghi de len phuong thuc cha va chuong trinh se truy cap vao phuong thuc cua con
    //    {
    //        Debug.Log("Move cua Boss");
    //    }
    //}

    //===================Bai_Tap===================
    public class Animal
    {
        public int name;
        public int sex;
        public int ivnt;
        public int eating;
        public int foot;

        public Animal(float eatfoodCP)
        {
            Debug.Log("Thang nay la cha");
        }

        public void Move()
        {
            Debug.Log("Method Move");
        }
        public void Eat()
        {
            Debug.Log("Method Eat");
        }
        public void Eat(float eatfood)
        {
            Debug.Log("Method EatFood");
        }
        public void Chating()
        {
            Debug.Log("Method Chating");
        }
    }
    public class Cat:Animal
    {
        public Cat(float eatfoodCP) : base(eatfoodCP)
        {
            Debug.Log("Thang nay la con");
        }
    }
}
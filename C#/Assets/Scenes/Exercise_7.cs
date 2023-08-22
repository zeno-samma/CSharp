using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_7: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy();//Neu chi truyen vao 1 tham so no se tu goi den  phuong thuc 1 tham so
        //enemy.Move();
        //Debug.Log($"Toc do Def: {enemy.MoveSpeed}");
        enemy.Bonus = 5;//Dung bien ao de thay doi gia tri 1 bien private trong lop.
        Debug.Log($"Gia tri bonus la: {enemy.Bonus}");
        //================Bai tap================
        PC pc = new PC();
        PC.locationwifi = 5;
        pc.Shutdown();
        pc.Nguon = 7;
        Debug.Log($"Gia tri bonus la: {pc.Nguon}");
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
    public class Enemy
    {
        public float moveSpeed;
        public float metectDist;
        public float mamage;
        private int bonus;        
        //-------------------------------------Get & Set---------------------
        public int Bonus { get; set;}
        //{
        //    get{
        //        return bonus;
        //    }
        //    set{
        //        bonus = value+1;
        //    }
        //}
        //====================================================================
        //public Enemy()//Phuong thuc khoi tao khong co gia tri
        //{
        //    Debug.Log("Day la phuong thuc khoi tao khoong co tham so truyen vao ");
        //}
        //public Enemy(float MoveSpeed) //Neu phuong thuc chi co 1 tham.
        //{
        //    this.MoveSpeed = moveSpeed;
        //    Debug.Log($"Day la phuong thuc khoi tao co tham so: {moveSpeed}");
        //}

        //public Enemy(float MoveSpeed, float DetectDist, float Damage)
        //{
        //    this.MoveSpeed = moveSpeed; 
        //    this.DetectDist = metectDist;       
        //    this.Damage = mamage;
        //    Debug.Log($"Day la phuong thuc khoi tao co tham so: {moveSpeed},{metectDist},{mamage}");
        //}
        //public void Move()
        //{

        //}
        //public void DetectPlayer()
        //{
        //}

    }

    //============Bai tap================
    public class PC
    {
        public int caseMaytinh;
        public int mainboard;
        public int ram;
        public int cpu;
        private int nguon;
        public int fan;
        public static int locationwifi;//Thuoc tinh dung chung
        public static int speedwifi;
        public static int onwwifi;
        public void Reset()
        {
            
        }
        public void Shutdown()
        {
            Debug.Log($"Tat nguon: {nguon}");
            Debug.Log($"locationwifi: {locationwifi}");
        }
        public void Ovelocking()
        {

        }
        public void GetSetDB()
        {

        }
        public int Nguon
        {
            get
            {
               return nguon;
            }
            set
            {
                nguon = value+1;
            }
        }
    }
}

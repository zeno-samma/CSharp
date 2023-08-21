using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.XR;
using UnityEngine;

public class OPP : MonoBehaviour
{

    //======================Ly Thuyet=======================
    //public class Phu_nu
    //{
    //    protected bool con_zin = true;
    //    protected string name;
    //    protected int tuoi;

    //    public Phu_nu() { } // Constructor khoi tao mac dinh
    //    public Phu_nu(string ht, int t)// Constructor khoi tao co tham so
    //    {
    //        this.con_zin = false;
    //        this.name = ht;
    //        this.tuoi = t;
    //    }
    //    public virtual void TrangDiem()//Method khong tra ve
    //    {

    //    }
    //     public virtual string Choi_Nhac_Cu(string nhac_cu)//Method tra ve gia tri
    //    {
    //        return "AAAAA";
    //    }
    //    public void Write ()//Method sua doi, cap nhat gia tri
    //    {
    //        if (tuoi < 25)
    //        {
    //            Debug.Log($"Da va zin,{tuoi}");
    //            this.con_zin = true;
    //        }
    //        else
    //        {
    //            Debug.Log($"Da qua gia");
    //        }
    //    }
    //    public void Read ()//Method show cac thuoc tinh
    //    {
    //        Debug.Log($"Check: {name}, con_zin : {con_zin}, Tuoi: {tuoi}");
    //    }
    //}

    //public class Gai_Ngoan : Phu_nu
    //{
    //    public Gai_Ngoan(string ht, int t):base(ht, t)// Constructor khoi tao co tham so
    //    {
    //        this.name = ht;
    //        this.tuoi = t;
    //    }
    //    public void Noi_Tro()
    //    {
    //        Debug.Log($"{name},Dang lam noi tro");
    //    }
    //    public override string Choi_Nhac_Cu(string nhac_cu)//Method tra ve gia tri
    //    {
    //        return "UUUUU";
    //    }
    //}

    //public class Gai_Hu : Phu_nu
    //{
    //    public Gai_Hu(string ht, int t) : base(ht, t)// Constructor khoi tao co tham so
    //    {
    //        this.name = ht;
    //        this.tuoi = t;
    //    }
    //    public void Di_Bar()
    //    {
    //        Debug.Log($"{name},Dang di bar");
    //    }
    //    public override string Choi_Nhac_Cu(string nhac_cu)//Method tra ve gia tri
    //    {
    //        return "Ohyeah";
    //    }
    //    public override void TrangDiem()
    //    {

    //    }
    //}
    //==========================================================
    //==============================Bai Tap=======================

    public class Animal
    {
        protected string name;
        protected string sex;
        protected string ivnt;
        protected string eat;
        protected float foot;
        protected string chating;
        //bool Death = false;   
        public Animal() { } // Constructor khoi tao mac dinh
        public Animal(string name_value)
        {
            this.name = name_value;
            Debug.Log($"Toi ten la: {name_value}");
        }
        public void Write()
        {
                //this.Death = true;
        }
        public void Show()
        {
            Debug.Log($"Name: {this.name}, Sex: {this.sex} , Moi truong: {this.ivnt} , Thuc an: {this.eat} , So chan: {this.foot}");
        }

        public virtual string Move()
        {
            return "Toi di chuyen bang...";
        }        
        public void Eat()
        {
            Debug.Log("Toi An...");
        }        
        public virtual string Eat(string eatFood_value)
        {
            return "Toi an gi...";
        }        
        public virtual string Chatting()
        {
            return "Toi keu...";
        }

    }
    public class Cat : Animal
    {

        public Cat()
        {
        }
        public Cat(string name_value) : base(name_value)// Constructor khoi tao co tham so
        {
            this.name = name_value;
        }


        public override string Move()
        {
            return "Di chuyen bang...bon chan ";
        }
        public override string Eat(string eatFood_value)
        {
            return "Toi an...thit ";
        }
        public override string Chatting()
        {
            return "Toi keu...Meo Meo ";
        }
    }

    void Start()
    {
        Animal animal = new Animal("QuaiVat");
        animal.Eat();
        Debug.Log($"{animal.Chatting()}");
        Animal ani = new Cat("Meo");
        Debug.Log($"{ani.Move()},{ani.Eat("eat")},{ani.Chatting()}");
    }
}

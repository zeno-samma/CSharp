using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Lib : MonoBehaviour
{
    public string s = "Xin chao the gioi";//Bien global
    const float DIEM_SO = 9.1f; //Khai bao hang se khong bi thay doi.
    enum InfoPlayer//Danh sach liet ke chi kieu int
    {
        Name = 0,
        Age = 10,
        Sex = 0
    }
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //--------Khai bao bien------------
    int a;
    int b;
    int d;
    //-------Mang-Array(Quan trong)----------------
    //1 chieu
    int[] ScoreArray0;//tao mot mang rong
    int[] ScoreArray1 = new int[10];//cach 1
    int[] ScoreArray2 = new int[] { 5, 8, 9, 10 };//cach 2
    int[] ScoreArray3 = { 5, 8, 9, 10 };//cach 3
    //2 chieu
    int[,] ScoreArray1_1;//cach 1 co the khoi tao mang rong sau do add gia tri sau
    int[,] ScoreArray2_2;//cach 2 co the khoi tao mang rong sau do add gia tri sau
    int[,] ScoreArray4 = new int[,]//cach 3 mang bat buoc phai co gia tri
            {
              {3, 5},
              {7, 8},
              {9, 10}
            }
        ;
    //int c;
    //-------------------Boxing
    //int value = 109;
    //object objectvalue;
    //int newvalue;
    //----------Logic-----------------
    //int a = 2; int b = 3;//Khai bao hang
    void Start()
    {
        //--------Khoi tao bien------------
        a = 2;
        b = 7;
        //----------Cap phat gia tri cho mang--------
        ScoreArray0 = new int[] { 5, 8, 9, 10 };
        if (a > b) //true 
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
        //Debug.Log("Ket qua: = " + (a++));// Thuc hien bieu thuc truoc roi sau do moi tang.
        //Debug.Log("Ket qua: = " + a);
        //Debug.Log("Ket qua: = " + (++b));//Tang gia tri bieu thuc roi moi thuc hien.
        //-------------------Toan tu 3 ngoi---------------
        //c = (a + b == 5) ? 5 : 8;
        //Debug.Log(c);
        //-------------------***Switch - case (Quan trong)---------------
        //------------------Neu cau lenh phu thuoc vao nhieu gia tri----------------
        switch (a + b)
        {
            case 3://(case [x]: x la gia tri)
                Debug.Log("false");
                break;
            case 8: //case null co the co hoac khong break
            case 9:
                Debug.Log("true");//Case cuoi cung bat buoc phai co break
                break;
            default:
                Debug.Log("Tat ca truong hop deu sai"); //switch case day du se co them default(mac dinh neu khong thoa cac truong hop tren).
                break;
        }
        //-------------------Kieu data object---------------
        //a.ToString();//Chuyen doi kieu data hien thi ra man hinh.
        //if (a.GetType().Equals(typeof(string)))
        //{
        //    Debug.Log("Kieu string");
        //}
        //else
        //{
        //    Debug.Log("Not type string");
        //}

        //Unboxing---------------
        //objectvalue = value;
        //newvalue = (int)objectvalue;
        //Debug.Log(newvalue);
        //-------------------Loop(Quan trong)---------------
        //---For Loop---------------
        //for (int i = 0; i < b; i++)
        //{
        //    Debug.Log("Lan lap thu: " + i);
        //}
        //---While Loop---------------
        //while (a + b < 20 ) {
        //    a++;
        //    b += a;
        //    Debug.Log("Gia tri a: " + a + "Gia tri b: "+b);
        //    Debug.Log($"Gia tri a: {a}, Gia tri = {b} ");
        //}
        string s = "Hello bro";//Bien local
        int d = 2;
        int g = 2;
        int h = 3;
        //LogString();//Neu khong gia tri tham so truyen vao se lay gia tri mac dinh
        LogString(d, s);//Neu khong gia tri tham so truyen vao se lay gia tri mac dinh
                        //Chi truyen vao ban sao cua bien d = 2 .

        //Debug.Log(d);//Gia tri thuc cua bien d = 2.
        int f = Sum(g, h);//Goi ham tra ve gia tri
        //Debug.Log(f);
        //------------Ref & out-----------
        ChangeA(ref a);//Giu gia tri cua bien sau khi thuc thi ham
        //Debug.Log(a);
        //---In mang & lap gia tri mang------
        //Debug.Log($"Do dai cua mang: {ScoreArray0.Length}");  
        for (int i = 0; i < ScoreArray0.Length; i++)
        {
            //Debug.Log($"Gia tri thu: {i}, co gia tri bang:  {ScoreArray0[i]}");
        }
        //--Dem va in phan tu cua mang------------
        int count = 0;
        while (count < ScoreArray0.Length)
        {
            //Debug.Log($"Gia tri thu: {count}, co gia tri bang: {ScoreArray0[count]}");
            count++;
        }
        //Duyet mang 2 chieu
        for (int i = 0; i < ScoreArray4.GetLength(0); i++)
        {
            for (int j = 0; j < ScoreArray4.GetLength(1); j++)
            {
                //Debug.Log(ScoreArray4[i,j]);
            }
        }
        //Duyet mang 2 chieu bang vong lap foreach
        foreach (int temp in ScoreArray4)
        {
            Debug.Log($"Duyet mang Foreach: {temp}");
        }
        //truy cap danh sach liet ke
        Debug.Log($"{(int)InfoPlayer.Age}");
    }
    //---Func(Quan trong)---------------
    void LogString(int d = 2, string str = "Hello")//Neu khong gia tri tham so truyen vao se lay gia tri mac dinh, nhung gia tri mac dinh luon phai dat phia sau.
    {
        d++;//Sau khi ket thuc ham gia tri d = 2 van khong thay doi.
        Debug.Log(d + str);//Tuy bien d = 3 duoc thay doi trong ham nhung gia tri thuc van la d = 2
    }
    public int Sum(int a, int b)//ham tra ve gia tri
    {
        int f = a + b;
        return f;//Kieu du lieu tra ve phai dung voi kieu cua ham(int)
    }
    //---Ref & Out---------------
    void ChangeA(ref int value)
    {
        value++;
    }
}

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    // Start is called before the first frame update
    int[] ScoreArray1 = new int[] { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 }; //Mang mot chieu
    void Start()
    {
        //Tinh trung binh cong 4 so bat ky
        //int a = 1; int b = 2; int c = 3; int d = 6; int e ;   
        //Debug.Log($"Sum: {e = (a + b + c + d)}, Trung binh cong: {e = (a+b+c+d)/4}");
        //Debug.Log("AAAA\taaa");
        //Tim so giong nhau trong mang
        //KhongTraVe();
        //Tinhtrungbinhcong();
        Tinhvantoc();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    void Tinhtrungbinhcong()
    {
        int a = 1; int b = 2; int c = 3; int d = 4;int e; int f;
        Debug.Log($"Tong cua 4 so la: {e = (a+b+c+d)}, Trung binh cong: {f = e/4}");
    }
    void Tinhvantoc()
    {
        //int a = 20; int b = 5; int e = 0;
        //Debug.Log($"Van toc bang: {e = (20/5)} Km/m");
    }
    //void KhongTraVe()
    //{
    //    for (int i = 0; i < ScoreArray1.Length; i++)
    //    {
    //         var pt0 = ScoreArray1[i];
    //        Debug.Log(pt0);
    //        if (pt0 == ScoreArray1[i+1])
    //        {
    //            Debug.Log($"So {pt0} la so trung trong mang");
    //        }
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------Execise 
public class Exercise_4 : MonoBehaviour
{
    // Start is called before the first frame update
    //Mang mot chieu
    int[] ScoreArray1 = new int[] { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };
    string Show;
    //Mang hai chieu
    int[,] ScoreArray4 = new int[,]
        {
              { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 },
              { 7, 3, 1, 9, 1, 8, 6, 10, 11, 17 },
              { 10, 21, 1, 3, 5, 9, 2, 4, 12, 18 }
        }
    ;
    void Start()
    {
        int sum = 0;
        //int product = 1;
        //ShowArray(ref Show);
        //FuncNon(ref sum);
        //FuncProduct(ref product);
        FuncNon_2(ref sum);
    }
    void ShowArray(ref string value)
    {
        for (int i = 0; i < ScoreArray1.Length; i++)
        {
            Show += (" " + ScoreArray1[i]);
        }
        Debug.Log($"Mang ScoreArray1 : {Show}");
    }
    void FuncNon(ref int value)
    {
        //Tim cac so chan, le in ra man hinh 
        //Debug.Log($"Mang ScoreArray1: = {ScoreArray1}");
        for (int i = 0; i < ScoreArray1.Length; i++)
        {

            if (ScoreArray1[i] % 2 == 0)
            {
                //Debug.Log("So chan");
                Debug.Log($"So : {ScoreArray1[i]}, la so chan trong mang");
            }
            else
            {
                Debug.Log($"So : {ScoreArray1[i]}, la so le trong mang");
            }
        }
        //Tinh tong cac so trong mang in ra man hinh
        for (int i = 0; i < ScoreArray1.Length; i++)
        {
            value += ScoreArray1[i];
        }
        Debug.Log($"Tong cua day so la : {value}");

    }    
    void FuncNon_2(ref int value)
    {
        //Tim cac so chan, le in ra man hinh 
        //Debug.Log($"Mang ScoreArray1: = {ScoreArray1}");
        for (int i = 0; i < ScoreArray4.GetLength(0); i++)
        {
            for (int j = 0; j < ScoreArray4.GetLength(1); j++)
            {
                if (ScoreArray4[i,j] % 2 == 0)
                {
                    //Debug.Log("So chan");
                    Debug.Log($"So : {ScoreArray4[i,j]}, la so chan trong mang");
                }
                else
                {
                    Debug.Log($"So : {ScoreArray4[i,j]}, la so le trong mang");
                }
            }

        }
        //Tinh tong cac so trong mang in ra man hinh
        //for (int i = 0; i < ScoreArray1.Length; i++)
        //{
        //    value += ScoreArray1[i];
        //}
        //Debug.Log($"Tong cua day so la : {value}");

    }
    void FuncProduct(ref int value)
    {
        //Tinh tich tat ca cac so in ra man hinh
        for (int i = 0; i < ScoreArray1.Length; i++)
        {
            value *= ScoreArray1[i];
        }
        Debug.Log($"Tich cua day so la : {value}");
    }
    //public int Func(int ScoreArray1)
    //{
    //    int f = 0;
    //    return f;
    //}
    // Update is called once per frame
    //void Update()
    //{

    //}
}

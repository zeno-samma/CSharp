using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    int a = 8;
    int b = 3;

    // Start is called before the first frame update
    private void Start()
    {
        //Hieucua2so(a, b);
        Pheptinh(a, b, 5);
    }
    //void Hieucua2so(int a, int b)
    //{
    //    if ((a + b) > 10)
    //    {
    //        Debug.Log($"Hieu cua 2 so la: {a - b}");
    //    }
    //    if ((a + b) > 7)
    //    {
    //        Debug.Log($"Tich cua 2 so la: {a*b}");
    //    }else
    //    {
    //        Debug.Log($"Thuong cua 2 so la: {a/b}");
    //    }
    //}
    int Pheptinh(int a, int b, int c)
    {
        int ketqua = 0;
        switch (c)
        {
            case 1:
                ketqua =  (a + b + c);
                break;
            case 2:
               ketqua = (a + b) * c;
                break;
            case 4:
                ketqua = (a * b) - (a + b);
                break;
            case 0:
              ketqua =(a * b * c) + c - a;
                break;
            default:
                Debug.Log("Khong co phep tinh nao thoa man");
                break;
        }
        return ketqua;
    }

}

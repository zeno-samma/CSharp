using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_6 : MonoBehaviour
{
       enum InfoPlayer
    {
        Name = 0,
        Age = 1,
        Sex = 0
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{(int)InfoPlayer.Age}");
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}

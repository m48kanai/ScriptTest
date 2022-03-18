using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください

        int[] arr = { 10, 20, 30, 40, 50 };

        //for文を使い、配列の各要素の値を順番に表示してください
        
        for(int i =0; i< 5; i++)
        {
            Debug.Log(arr[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示してください

        for (int e = arr.Length - 1 ; e >= 0; e--)
        {
            Debug.Log(arr[e]);
        
        }
    }




    void Update()
    {

    }
}


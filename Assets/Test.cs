using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    void Start()
    {
        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������

        int[] arr = { 10, 20, 30, 40, 50 };

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        
        for(int i =0; i< 5; i++)
        {
            Debug.Log(arr[i]);
        }

        //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������

        for (int e = arr.Length - 1 ; e >= 0; e--)
        {
            Debug.Log(arr[e]);
        
        }
    }




    void Update()
    {

    }
}


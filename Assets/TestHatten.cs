using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic
{
    //int�^�̕ϐ�mp��錾���A53�ŏ��������Ă�������
    private int mp = 53;

    // mp������Ė��@�U��������Magic�֐�������Ă�������
    //Magic�֐�����mp��5�ȏ�̏ꍇ��5���炵�A�R���\�[���� ���@�U���������B�c��MP�́Z�Z�B �ƕ\�����Ă�������
    //mp������Ȃ��ꍇ�AMP������Ȃ����߁A���@���g���Ȃ��B �ƕ\�����Ă�������
    public void MagicAttack()
    {
        Debug.Log("���@�U��������");
    }

    public void MagickLoss(int mpshouhi)
    {
        this.mp -= mpshouhi;

        if ( mp > 0)
        {          
            Debug.Log(mpshouhi + "MP�������");
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }


    }

}

public class TestHatten : MonoBehaviour
{

    void Start()
    {
        // Magic�N���X�̕ϐ���錾���ăC���X�^���X����
        Magic lastMagic = new Magic();

        // Magic�֐����Ăяo���āA���@���g���Ă�������
        lastMagic.MagicAttack();
        lastMagic.MagickLoss(5);

        //Magic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁAmp������Ȃ����b�Z�[�W��\������
        for (int a = 0; a < 10; a++)
        {
            lastMagic.MagicAttack();
            lastMagic.MagickLoss(5);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
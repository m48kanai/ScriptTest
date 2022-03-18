using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic
{
    //int型の変数mpを宣言し、53で初期化してください
    private int mp = 53;

    // mpを消費して魔法攻撃をするMagic関数を作ってください
    //Magic関数内でmpを5以上の場合は5減らし、コンソールに 魔法攻撃をした。残りMPは〇〇。 と表示してください
    //mpが足りない場合、MPが足りないため、魔法が使えない。 と表示してください
    public void MagicAttack()
    {
        Debug.Log("魔法攻撃をした");
    }

    public void MagickLoss(int mpshouhi)
    {
        this.mp -= mpshouhi;

        if ( mp > 0)
        {          
            Debug.Log(mpshouhi + "MPを消費した");
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }


    }

}

public class TestHatten : MonoBehaviour
{

    void Start()
    {
        // Magicクラスの変数を宣言してインスタンスを代入
        Magic lastMagic = new Magic();

        // Magic関数を呼び出して、魔法を使ってください
        lastMagic.MagicAttack();
        lastMagic.MagickLoss(5);

        //Magic関数を10回使った後に、さらにMagic関数を呼び出すと、mpが足りないメッセージを表示する
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
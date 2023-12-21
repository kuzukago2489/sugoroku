using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    public GameObject dice;
    public int[] diceID = new int[3];
    // サイコロの面の数
    public int numberOfSides = 6;
    void Start()
    {
         
    }

    // サイコロのランダムな値を取得するメソッド
    private int RollDice()
    {
        int i = 0;
        int x = 0;
        switch (diceID[i]) {
            case 1:
                x = Random.Range(1, numberOfSides + 1);
                break;
            case 2:
                x = Random.Range(4, 7);
                break;
         }
        return x;
    }

    // スペースバーが押された時に呼ばれるメソッド
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // サイコロを振り、結果を取得
            int result = RollDice();

            // 結果をログに表示
            Debug.Log("サイコロの結果: " + result);
        }
    }
    
       
}

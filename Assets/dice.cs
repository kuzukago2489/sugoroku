using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    public GameObject dice;
    public int[] diceID = new int[3];
    // �T�C�R���̖ʂ̐�
    public int numberOfSides = 6;
    void Start()
    {
         
    }

    // �T�C�R���̃����_���Ȓl���擾���郁�\�b�h
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

    // �X�y�[�X�o�[�������ꂽ���ɌĂ΂�郁�\�b�h
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �T�C�R����U��A���ʂ��擾
            int result = RollDice();

            // ���ʂ����O�ɕ\��
            Debug.Log("�T�C�R���̌���: " + result);
        }
    }
    
       
}

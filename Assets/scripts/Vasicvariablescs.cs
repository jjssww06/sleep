using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vasicvariablescs : MonoBehaviour
{
    public int gold = 0;                        //������
    public float Hp = 100.0f;                   //�Ǽ���()�Ҽ����� �ִ� ����,���� 'f'�ʼ�)
    public string playerName = "ȫ�浿";        //���ڿ� (������ ����)
    private bool isAlive = true;                //���� (��/������ ��Ÿ��) ture/false


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("���ӽ���");      //����Ƽ ����׿� �޼����� ���

        if(gold > 50)
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�.");
        }
        else  if(gold > 25)
        {
            Debug.Log("�Ϻ� �������� ������ �� �ֽ��ϴ�.");
        }
        else
        {
            Debug.Log("���� �����մϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log("���� ������");
       if(Input.GetKeyDown(KeyCode.Space))
        {
            gold = gold + 10;                       //��带 10����
            Debug.Log("���� ��� : " + gold);       //���� ��带 ���
        }
    }
}

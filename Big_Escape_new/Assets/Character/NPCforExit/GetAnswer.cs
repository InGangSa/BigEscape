using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAnswer : MonoBehaviour
{
    public static int answer = 0;
    public GameObject pass; // ���ӿ�����Ʈ�� �ޱ�



    public void check(InputField f) //InputField�� f�� ����
    {

        if (f.text == "3.4") //InputField�� text�� �˻��Ͽ� "3.4"�϶� ����
        {
            answer = 1;
            print("���踦 ã�Ҵ�!");
            pass.SetActive(false); // �Է¹ް� Uiâ�� ����
        }

        else print("Ʋ����");
        pass.SetActive(false);
    }
}

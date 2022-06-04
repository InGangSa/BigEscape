using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAnswer : MonoBehaviour
{
    public static int answer = 0;
    public GameObject pass; // 게임오브젝트로 받기



    public void check(InputField f) //InputField를 f로 선언
    {

        if (f.text == "3.4") //InputField에 text를 검사하여 "3.4"일때 실행
        {
            answer = 1;
            print("열쇠를 찾았다!");
            pass.SetActive(false); // 입력받고 Ui창이 꺼짐
        }

        else print("틀린답");
        pass.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : MonoBehaviour
{    
    Rigidbody2D rigid;
    public int Speed;
    

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        RandSpeed();
    }
  
    void Update()
    {
        rigid.velocity = new Vector2(rigid.velocity.x, Speed);
        restart();
    }

    void RandSpeed() //속도 랜덤으로 주는 함수
    {
        Speed = Random.Range(-10, -5);
    }

    void restart()
    {
        float posy = gameObject.transform.position.y;
        if (posy <= -120) //특정 위치에 도착하면 
        {
            gameObject.transform.position = new Vector2(239, -36); //지정한 위치로 다시 이동
            RandSpeed(); // 속도 재설정하고
            rigid.velocity = new Vector2(rigid.velocity.x, Speed); //다시 출발
            
        }
    }

}

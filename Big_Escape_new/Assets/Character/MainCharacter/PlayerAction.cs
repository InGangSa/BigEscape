using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    float moveX, moveY;

    [Header("이동속도 조절")]
    [SerializeField] [Range(1f, 30f)] float moveSpeed = 20f;
    
    
    void Update()
    {
        //이동 (상하좌우키 : WSAD키 혹은 상하좌우이동키)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);

        Vector3 flipMove = Vector3.zero;

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            flipMove = Vector3.left;
            transform.localScale = new Vector3(1, 1, 1);
        }

        else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            flipMove = Vector3.right;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        transform.position += flipMove * moveSpeed * Time.deltaTime;
    }
}

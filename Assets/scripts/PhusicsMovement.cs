using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PhusicsMovement : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float jumpForce = 5f;

    public Rigidbody rb;

    private bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //이동 처리
        float moveX = Input.GetAxis("Horizontal");      //좌우 이동
        float moveZ = Input.GetAxis("Vertical");        //앞뒤 이동

        Vector3 Direction = new Vector3(moveX, 0, moveZ).normalized;            //이동 방향 백터

        //Rigidbody에 힘을 주어 이동
        rb.MovePosition(transform.position + Direction * moveSpeed * Time.deltaTime);

        //점프 처리
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)

        {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    //충돌 감지
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;              //바닥에 닿았을때
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;             //바닥에서 떨어졌을때
    }
}

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
        //�̵� ó��
        float moveX = Input.GetAxis("Horizontal");      //�¿� �̵�
        float moveZ = Input.GetAxis("Vertical");        //�յ� �̵�

        Vector3 Direction = new Vector3(moveX, 0, moveZ).normalized;            //�̵� ���� ����

        //Rigidbody�� ���� �־� �̵�
        rb.MovePosition(transform.position + Direction * moveSpeed * Time.deltaTime);

        //���� ó��
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)

        {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    //�浹 ����
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;              //�ٴڿ� �������
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;             //�ٴڿ��� ����������
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsulemove : MonoBehaviour
{
    public float speed = 5.0f;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))         //Getkey�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))         //Getkey�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))         //Getkey�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))         //Getkey�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


    }
}

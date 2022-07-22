using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterControll : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space)&& condition==true)
        {
            //AddForce : 객체에 일정한 힘을 가하는 함수입니다.
            rigid.AddForce(new Vector3(0, 300, 0));
            condition = false;

        }
        //물리적인 충돌을 했을때 동작하는 함수입니다.       
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position+direction.normalized*speed*Time.fixedDeltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }
    //물리적인 충돌을 하고 있을때 동작하는 함수.
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}

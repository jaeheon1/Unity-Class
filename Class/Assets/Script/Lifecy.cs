using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ʱ�ȭ �Լ����� ���� ( ������ ����ɶ� �� �ѹ��� ȣ�� �˴ϴ�.)
//awake() ���� ������Ʈ ��Ȱ��ȭ���������� ����Ǵ��Լ�. 
//start() ���� ������Ʈ Ȱ��ȭ �Ǿ������� ����Ǵ� �Լ�. 
//onEnable() ���� ������Ʈ Ȱ��ȭ �� ������ ȣ��Ǵ� �Լ�. 

//���� ���� 
//������ ���·� �浹�ϰ� �Ǹ� �ұ�Ģ�ϰ� �浹 �˴ϴ�.
//Fip Update  : Timestep �� ������ ���� ���� ������ �������� �浹�� ó���ϱ� ���� ������Ʈ �Լ�.
public class Lifecy : MonoBehaviour
{
    int health = 0;
    private void Awake()
    {
        Debug.Log("Tiger");
    }



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tiger start");
    }
    private void OnEnable()
    {
        Debug.Log("Tiger Oneable");
    }
    // Update is called once per frame
    void Update()
    {
        health++;
        Debug.Log(health);
        if(health>=100)
       
                health=0;
    }
    private void FixedUpdate()
    {
        Debug.Log("Tiger Fixed Update");
    }
}

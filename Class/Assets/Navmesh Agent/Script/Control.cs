using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class Control : MonoBehaviour
{
    public float speed = 8.0f;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        
    }

 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Raycasthit : 광선과 충돌한 오브젝트이 물체에 대한정보 저장.
            RaycastHit hit;

            //카메라로 부터 스크린 공간의 마우스 포인터를 통해 위치 정보 저장합니다.
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            //out: 출력용 매개변수
            //읽기 전용 매개변수입니다. 
            if (Physics.Raycast(ray, out hit,Mathf.Infinity))
            {
                Move(hit.point);   
            }
        }
    }
    public void Move(Vector3 Position)
    {
        agent.speed = speed;
        agent.SetDestination(Position);
    }
}

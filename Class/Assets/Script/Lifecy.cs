using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//초기화 함수들의 공통 ( 게임이 실행될때 단 한번만 호출 됩니다.)
//awake() 게임 오브젝트 비활성화도었을때도 실행되는함수. 
//start() 게임 오브젝트 활성화 되었을때만 실행되는 함수. 
//onEnable() 게임 오브젝트 활성화 될 때마다 호출되는 함수. 

//물리 연산 
//프레임 형태로 충돌하게 되면 불규칙하게 충돌 됩니다.
//Fip Update  : Timestep 의 설정된 값에 따라 일정한 간격으로 충돌을 처리하기 위한 업데이트 함수.
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

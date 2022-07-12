using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour  // main()
{
    // 게임 오브젝트 속성 초기화
    //필드 
    // 변수 선언
    int health;//초기화를 하지 않아도 0 이라는 값으로 저장됩니다.

    void Start()
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update() //유니티에서 제공해주는 함수
    {
        //로직
    }
}

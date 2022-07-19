using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendAnimation : MonoBehaviour
{
  public Animator animator;
    void Start()
    {
        //animator<-애니메이터 컴포넌트 
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        // 수평에 대한 정보 GetAxis 에는 내가 원하는 입력 정보를 넣어주어야합니다.
        //Left Key를 누르면 -1 
        //Right Key를 누르면 1 
        //x축 -1-1 사이의 값을 변환합니다.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal",horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}

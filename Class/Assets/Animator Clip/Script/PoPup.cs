using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoPup : MonoBehaviour
{
    public Animator animator;
    public GameObject window;
    
  
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            //현재애니메이션의 진행도가 1보다 크거나 갈타면 window 오브젝트를 비활성화합니다
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime>=1)
            {
                window.SetActive(false);
            }
        }
    }
    public void close()
    {
        animator.SetTrigger("Close");
    }
    public void PopUpOpen()
    {
        window.SetActive(true);
    }
}

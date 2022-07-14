using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//초기화 함수들의 공통 ( 게임이 실행될때 단 한번만 호출 됩니다.)
//awake() 게임 오브젝트 비활성화도었을때도 실행되는함수. 
//start() 게임 오브젝트 활성화 되었을때만 실행되는 함수. 
//onEnable() 게임 오브젝트 활성화 될 때마다 호출되는 함수. 

//물리 연산 
//프레임 형태로 충돌하게 되면 불규칙하게 충돌 됩니다.
//Fip Update  : Timestep 의 설정된 값에 따라 일정한 간격으로 충돌을 처리하기 위한 업데이트 함수.

//유니티에서는 소멸자가 존재하지 않습니다.
[System.Serializable]
public class Data
{
    //변수
    //기본 접근 지정자는 private 
    //기본 생성자를 선언하지 않으면 자동으로 기본 생성자를 생성시켜줍니다.
    public int price;
    public Sprite sprite;
    public string name;
}




public class Lifecy : MonoBehaviour
{
    public int [] health;// 배열의 크기는 (?)
    
    public Data [] Data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    Stack<int>stack=new Stack<int>();
    private void Awake()
    {
        for(int i=0;i<Data.Length;i++)
        {
            priceUI[i].text = Data[i].price.ToString();
            nameUI[i].text = Data[i].name;
            spriteUI[i].sprite = Data[i].sprite;
        }
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
   
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger Fixed Update");
    }

    private void OnDisable()
    {
        // 게임 오브젝트가 비활성화 될때마다 호출되는 함수입니다.
        Debug.Log("Tiger OnDisable");
    }
    private void OnDestroy()
    {
        //게임 오브젝트가 파괴되는 순간 호출되는 함수입니다.

    }
}

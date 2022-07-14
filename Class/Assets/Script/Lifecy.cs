using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�ʱ�ȭ �Լ����� ���� ( ������ ����ɶ� �� �ѹ��� ȣ�� �˴ϴ�.)
//awake() ���� ������Ʈ ��Ȱ��ȭ���������� ����Ǵ��Լ�. 
//start() ���� ������Ʈ Ȱ��ȭ �Ǿ������� ����Ǵ� �Լ�. 
//onEnable() ���� ������Ʈ Ȱ��ȭ �� ������ ȣ��Ǵ� �Լ�. 

//���� ���� 
//������ ���·� �浹�ϰ� �Ǹ� �ұ�Ģ�ϰ� �浹 �˴ϴ�.
//Fip Update  : Timestep �� ������ ���� ���� ������ �������� �浹�� ó���ϱ� ���� ������Ʈ �Լ�.

//����Ƽ������ �Ҹ��ڰ� �������� �ʽ��ϴ�.
[System.Serializable]
public class Data
{
    //����
    //�⺻ ���� �����ڴ� private 
    //�⺻ �����ڸ� �������� ������ �ڵ����� �⺻ �����ڸ� ���������ݴϴ�.
    public int price;
    public Sprite sprite;
    public string name;
}




public class Lifecy : MonoBehaviour
{
    public int [] health;// �迭�� ũ��� (?)
    
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
        // ���� ������Ʈ�� ��Ȱ��ȭ �ɶ����� ȣ��Ǵ� �Լ��Դϴ�.
        Debug.Log("Tiger OnDisable");
    }
    private void OnDestroy()
    {
        //���� ������Ʈ�� �ı��Ǵ� ���� ȣ��Ǵ� �Լ��Դϴ�.

    }
}

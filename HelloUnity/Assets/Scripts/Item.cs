using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //�ɹ� ����
    public int damage; // �ν����� �ʵ� ����
    public float attackSpeed;
    public bool isBroken;
    public string itemName;


    private void Awake() // �̹� ���ǵ� �̺�Ʈ �Լ�
    {
        Debug.Log("Awake �ż��� ȣ���!");

        Debug.Log($"���ݷ�: {this.damage}"); // ��Ʈ �⺻ 0
        Debug.Log($"���ݷ�: {0}, {this.damage}");

        Debug.Log($"���� �ӵ�: {0}, {this.attackSpeed}");
        Debug.Log($"�ı� ����: {0}, {this.isBroken}");
        Debug.Log($"������ �̸�: {0}, {this.itemName}");
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //맴버 변수
    public int damage; // 인스팩터 필드 생성
    public float attackSpeed;
    public bool isBroken;
    public string itemName;


    private void Awake() // 이미 정의된 이벤트 함수
    {
        Debug.Log("Awake 매서드 호출됨!");

        Debug.Log($"공격력: {this.damage}"); // 인트 기본 0
        Debug.Log($"공격력: {0}, {this.damage}");

        Debug.Log($"공격 속도: {0}, {this.attackSpeed}");
        Debug.Log($"파괴 가능: {0}, {this.isBroken}");
        Debug.Log($"아이템 이름: {0}, {this.itemName}");
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

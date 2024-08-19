using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;


    private void Awake()
    {
        //카운트
        Debug.Log($"<color=red>{itemGos.Count}</color>");

        // 순회해 아이템 이름 출력
        //foreach (var item in itemGos)
        //{
        //    Debug.Log(item.name);
        //}

        for (int i = 0; i < itemGos.Count; i++)
        {
            Debug.Log($"{i} = {this.itemGos[i]}");

            GameObject itemGo = this.itemGos[i];
            
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"{item.itemName}");

        }


    }

  
}

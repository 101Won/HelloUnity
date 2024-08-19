using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;


    private void Awake()
    {
        //ī��Ʈ
        Debug.Log($"<color=red>{itemGos.Count}</color>");

        // ��ȸ�� ������ �̸� ���
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

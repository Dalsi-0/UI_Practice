using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UISlot : MonoBehaviour
{
    [SerializeField] private ItemSO itemData;
    [SerializeField] private Image icon;
    [SerializeField] private bool isEquip;
    [SerializeField] private GameObject equipObject;

    public void SetItem(ItemSO itemData)
    {
        this.itemData = itemData;
        isEquip = false;
    }

    public void RefreshUI()
    {
        icon.sprite = itemData.ItemIcon;
    }
}

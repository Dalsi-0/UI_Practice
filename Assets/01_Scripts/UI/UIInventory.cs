using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Transform content;
    [SerializeField] UISlot uiSlotPrefabs;
    [SerializeField] List<UISlot> uiSlotList;
    [SerializeField] ItemSO[] defaultEquipment;

    private void Start()
    {
        InitInventoryUI();
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);
    }

    public void AddItem(ItemSO itemData)
    {
        UISlot obj = Instantiate(uiSlotPrefabs, content);
        obj.SetItem(itemData);
        obj.RefreshUI();
        uiSlotList.Add(obj);
    }

    public void InitInventoryUI()
    {
        for (int i = 0; i < defaultEquipment.Length; i++)
        {
            AddItem(defaultEquipment[i]);
        }
    }

    public List<UISlot> GetUISlotList()
    {
        return uiSlotList;
    }
}

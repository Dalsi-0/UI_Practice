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

    private void Start()
    {
        InitInventoryUI();
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);
    }

    /// <summary>
    /// 인벤토리 UI 초기화
    /// </summary>
    public void InitInventoryUI()
    {
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }
        uiSlotList.Clear();

        for (int i = 0; i < 120; i++)
        {
            UISlot slot = Instantiate(uiSlotPrefabs, content);
            uiSlotList.Add(slot);
        }
    }

    /// <summary>
    /// 인벤토리에 아이템 추가
    /// </summary>
    public void AddItem(ItemSO itemData)
    {
        for (int i = 0; i < uiSlotList.Count; i++)
        {
            if (uiSlotList[i].GetItemData() == null)
            {
                uiSlotList[i].SetItem(itemData);
                uiSlotList[i].RefreshUI();
                break;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class UISlot : MonoBehaviour
{
    [SerializeField] private EventTrigger eventTrigger;
    [SerializeField] private ItemSO itemData;
    [SerializeField] private Image icon;
    [SerializeField] private bool isEquip;
    [SerializeField] private GameObject equipObject;

    /// <summary>
    /// 초기화. 슬롯을 비우고 클릭 이벤트를 등록.
    /// </summary>
    private void Start()
    {
        itemData = null;
        icon.enabled = false;
        equipObject.SetActive(false);
        isEquip = false;

        AddEventTrigger(OnMouseClick, EventTriggerType.PointerClick);
    }

    /// <summary>
    /// 슬롯에 아이템을 설정.
    /// </summary>
    /// <param name="itemData">설정할 아이템 데이터</param>
    public void SetItem(ItemSO itemData)
    {
        this.itemData = itemData;
        isEquip = false;
    }

    /// <summary>
    /// UI 갱신. 아이콘을 설정하거나 숨김.
    /// </summary>
    public void RefreshUI()
    {
        icon.enabled = true;
        icon.sprite = itemData.ItemIcon;
    }

    /// <summary>
    /// 슬롯의 아이템 데이터를 반환.
    /// </summary>
    /// <returns>슬롯에 저장된 아이템 데이터</returns>
    public ItemSO GetItemData()
    {
        return itemData;
    }

    /// <summary>
    /// 마우스 클릭 시 장착/해제 토글.
    /// </summary>
    /// <param name="eventData">클릭 이벤트 데이터</param>
    public void OnMouseClick(BaseEventData eventData)
    {
        PointerEventData pointerData = eventData as PointerEventData;
        if (itemData != null && pointerData != null && pointerData.button == PointerEventData.InputButton.Right)
        {
            isEquip = !isEquip;
            equipObject.SetActive(isEquip);

            Character player = GameManager.Instance.GetPlayer();
            if (isEquip)
            {
                player.Equip(itemData);
            }
            else
            {
                player.UnEquip(itemData);
            }
        }
    }

    /// <summary>
    /// EventTrigger에 이벤트를 추가.
    /// </summary>
    private void AddEventTrigger(UnityAction<BaseEventData> action, EventTriggerType eventType)
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = eventType;
        entry.callback.AddListener(action);
        eventTrigger.triggers.Add(entry);
    }
}

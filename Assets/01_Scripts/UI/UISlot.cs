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

    private void Start()
    {
        itemData = null;
        icon.enabled = false;
        equipObject.SetActive(false);
        isEquip = false;

        AddEventTrigger(OnMouseClick, EventTriggerType.PointerClick);
    }
    public void SetItem(ItemSO itemData)
    {
        this.itemData = itemData;
        isEquip = false;
    }

    public void RefreshUI()
    {
        icon.enabled = true;
        icon.sprite = itemData.ItemIcon;
    }

    public ItemSO GetItemData()
    {
        return itemData;
    }

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
    
    private void AddEventTrigger(UnityAction<BaseEventData> action, EventTriggerType eventType)
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = eventType;
        entry.callback.AddListener(action);
        eventTrigger.triggers.Add(entry);
    }
}

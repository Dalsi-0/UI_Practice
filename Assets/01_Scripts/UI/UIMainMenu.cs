using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button statusButton;
    [SerializeField] Button inventoryButton;

    private void Start()
    {
        statusButton.onClick.AddListener(UIManager.Instance.OpenStatus);
        inventoryButton.onClick.AddListener(UIManager.Instance.OpenInventory);
    }
}

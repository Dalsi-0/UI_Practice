using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }


    [SerializeField] Button buttonRandomGachaItem;
    [SerializeField] GameObject canvasMainMenu;
    [SerializeField] GameObject canvasStatus;
    [SerializeField] GameObject canvasInventory;
    [SerializeField] UIMainMenu uiMainMenu;
    [SerializeField] UIStatus uiStatus;
    [SerializeField] UIInventory uiInventory;
    public UIMainMenu UIMainMenu => uiMainMenu;
    public UIStatus UIStatus => uiStatus;
    public UIInventory UIInventory => uiInventory;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            buttonRandomGachaItem.onClick.AddListener(RandomGachaItem);
            OpenMainMenu();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OpenMainMenu()
    {
        canvasStatus.SetActive(false);
        canvasInventory.SetActive(false);
    }


    public void OpenStatus()
    {
        canvasStatus.SetActive(true);
        canvasInventory.SetActive(false);
        UIStatus.RefreshUI();
    }

    public void OpenInventory()
    {
        canvasStatus.SetActive(false);
        canvasInventory.SetActive(true);
    }

    public void RandomGachaItem()
    {
        ItemSO[] list = GameManager.Instance.GetAllItems();
        int randomIndex = Random.Range(0, list.Length);
        GameManager.Instance.GetPlayer().Additem(list[randomIndex]);
    }
}

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

    /// <summary>
    /// 메인 메뉴 UI를 활성화하고 다른 UI는 비활성화
    /// </summary>
    public void OpenMainMenu()
    {
        canvasStatus.SetActive(false);
        canvasInventory.SetActive(false);
    }

    /// <summary>
    /// 스테이터스 UI를 활성화하고 다른 UI는 비활성화
    /// </summary>
    public void OpenStatus()
    {
        canvasStatus.SetActive(true);
        canvasInventory.SetActive(false);
        UIStatus.RefreshUI();
    }

    /// <summary>
    /// 인벤토리 UI를 활성화하고 다른 UI는 비활성화
    /// </summary>
    public void OpenInventory()
    {
        canvasStatus.SetActive(false);
        canvasInventory.SetActive(true);
    }

    /// <summary>
    /// 랜덤 아이템을 획득하여 플레이어 인벤토리에 추가
    /// </summary>
    public void RandomGachaItem()
    {
        ItemSO[] list = GameManager.Instance.GetAllItems();
        int randomIndex = Random.Range(0, list.Length);
        GameManager.Instance.GetPlayer().Additem(list[randomIndex]);
    }
}

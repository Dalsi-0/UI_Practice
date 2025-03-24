using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }


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
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OpenMainMenu()
    {
        UIStatus.gameObject.SetActive(false);
        UIInventory.gameObject.SetActive(false);
    }


    public void OpenStatus()
    {
        UIStatus.gameObject.SetActive(true);
        UIInventory.gameObject.SetActive(false);
        UIStatus.RefreshUI();
    }

    public void OpenInventory()
    {
        UIStatus.gameObject.SetActive(false);
        UIInventory.gameObject.SetActive(true);
    }
}

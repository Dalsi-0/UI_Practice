using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);
    }
}

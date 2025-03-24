using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] TextMeshProUGUI atkText;
    [SerializeField] TextMeshProUGUI defText;
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] TextMeshProUGUI cirticalText;

    private void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);
    }

    public void RefreshUI()
    {
        Character player = GameManager.Instance.GetPlayer();

        atkText.text = $"{player.atk}";
        defText.text = $"{player.def}";
        hpText.text = $"{player.hp}";
        cirticalText.text = $"{player.critical}";
    }
}

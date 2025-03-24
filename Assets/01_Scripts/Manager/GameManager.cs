using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private Character player;
    [SerializeField] ItemSO[] defaultEquipment;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            SetData("myName", 12, 10, 7, 9999, 10, 5, 50, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        for (int i = 0; i < defaultEquipment.Length; i++)
        {
            player.Additem(defaultEquipment[i]);
        }
    }

    public Character GetPlayer()
    {
        return player;
    }


    public void SetData(string name, int lv, int exp, int expMax, int gold, int atk, int def, int hp, int critical)
    {
        player = new(name, lv, expMax, exp, gold, atk, def, hp, critical);
    }
}

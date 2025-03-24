using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string charName { get; private set; }
    public int lv { get; private set; }
    public int exp { get; private set; }
    public int expMax { get; private set; }
    public int gold { get; private set; }
    public int atk { get; private set; }
    public int def { get; private set; }
    public int hp { get; private set; }
    public int critical { get; private set; }
   // public List<ItemData> inventory;

    public Character(string charName, int lv, int expMax, int exp, int gold, int atk, int def, int hp, int critical)
    {
        this.charName = charName;
        this.lv = lv;
        this.exp = exp;
        this.expMax = expMax;
        this.gold = gold;
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.critical = critical;
     //   inventory = new List<ItemData>();
    }
/*
    public void Equip(ItemData itemData)
    {
        attack += itemData.attack;
        armor += itemData.armor;
        hp += itemData.hp;
        critical += itemData.critical;
        UIManager.Instance.uiStatus.RefreshUI();
    }

    public void UnEquip(ItemData itemData)
    {
        attack -= itemData.attack;
        armor -= itemData.armor;
        hp -= itemData.hp;
        critical -= itemData.critical;
        UIManager.Instance.uiStatus.RefreshUI();
    }*/
}

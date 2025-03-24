using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
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
    public List<ItemSO> myInventory;

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
        myInventory = new List<ItemSO>();
    }

    public void Additem(ItemSO itemData)
    {
        myInventory.Add(itemData);
        UIManager.Instance.UIInventory.AddItem(itemData);
    }

    public void Equip(ItemSO itemData)
    {
        atk += itemData.Atk;
        def += itemData.Def;
        hp += itemData.HP;
        critical += itemData.Critical;
    }

    public void UnEquip(ItemSO itemData)
    {
        atk -= itemData.Atk;
        def -= itemData.Def;
        hp -= itemData.HP;
        critical -= itemData.Critical;
    }
}

using UnityEngine;


[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Object/Item/Equipment", order = int.MaxValue)]
public class ItemSO : ScriptableObject
{
    [SerializeField] private Sprite itemIcon;
    [SerializeField] private int atk;
    [SerializeField] private int def;
    [SerializeField] private int hp;
    [SerializeField] private int critical;

    public Sprite ItemIcon => itemIcon;
    public int Atk => atk;
    public int Def => def;
    public int HP => hp;
    public int Critical => critical;

}
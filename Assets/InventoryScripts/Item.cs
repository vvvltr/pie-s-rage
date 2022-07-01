using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Item/Create new usable item")]
public class Item : ScriptableObject
{
    public int id;
    public string name;
    public Sprite icon;
}

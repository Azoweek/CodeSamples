using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public enum ShieldName
{
    CommonShield,
    StrongShield,
    MegaShield
}


[Serializable]
[CreateAssetMenu(fileName = "ShieldData", menuName = "Config/ShieldData")]
public class ShieldData : ScriptableObject
{
    public ShieldName Name;
    public int Health;
    public int Armor;

    public GameObject PrefabView;
}

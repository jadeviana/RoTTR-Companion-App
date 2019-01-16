using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Marketplace Card", menuName= "Marketplace Item/Card")]
public class MKTCard : ScriptableObject {

    public Sprite cardImage;

    public string cardName;
    public string description;

    public int credit;

}

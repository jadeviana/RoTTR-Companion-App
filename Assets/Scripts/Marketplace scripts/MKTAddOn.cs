using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Marketplace Add-On", menuName = "Marketplace Item/Add-on")]
public class MKTAddOn : ScriptableObject {

    public Sprite addOnImage;
    public Sprite buttonImage;

    public string addOnName;
    public string summary;
    public string description;

    public float price;
}

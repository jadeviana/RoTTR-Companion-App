using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class addOnScreenDisplay : MonoBehaviour {

    public MKTAddOn addon;

    public Image screenImage;

    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI value;

    // Use this for initialization
    void Start () {
        screenImage.sprite = addon.addOnImage;

        title.text = addon.addOnName;
        description.text = addon.description;
        value.text = "R$ " + addon.price.ToString();
    }
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MktAddOnCardDisplay : MonoBehaviour {

    public MKTAddOn addon;

    public Image btnImage;

    public TextMeshProUGUI addOnTitle;
    public TextMeshProUGUI addOnSummary;

    // Use this for initialization
    void Start () {

        btnImage.sprite = addon.buttonImage;

        addOnTitle.text = addon.addOnName;
        addOnSummary.text = addon.summary;
    }
	
}

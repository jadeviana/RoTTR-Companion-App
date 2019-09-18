using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MktAddOnCardDisplay : MonoBehaviour {
    public MKTAddOn addon;
    [SerializeField] private Image btnImage;
    [SerializeField] private TextMeshProUGUI addOnTitle;
    [SerializeField] private TextMeshProUGUI addOnSummary;

    public MarketplaceManager manager;

    void Start () {
        btnImage.sprite = addon.buttonImage;
        addOnTitle.text = addon.addOnName;
        addOnSummary.text = addon.summary;
    }

    public void SetAddOnScreen(){
        manager.OpenAddOnScreen(addon);
    }
	
}

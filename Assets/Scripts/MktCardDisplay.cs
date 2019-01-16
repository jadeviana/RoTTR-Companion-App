using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MktCardDisplay : MonoBehaviour {

    public MKTCard card;

    public Image cardPack;

    public TextMeshProUGUI cardTitle;
    public TextMeshProUGUI cardValue;

	// Use this for initialization
	void Start () {

        cardPack.sprite = card.cardImage;
        cardTitle.text = card.cardName;
        cardValue.text = card.credit.ToString();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MktCardDisplay : MonoBehaviour {
    public MKTCard card;
    [SerializeField] private Image cardPack;
    [SerializeField] private TextMeshProUGUI cardTitle;
    [SerializeField] private TextMeshProUGUI cardValue;

    public MarketplaceManager manager;

	void Start () {
        cardPack.sprite = card.cardImage;
        cardTitle.text = card.cardName;
        cardValue.text = card.credit.ToString(); 
    }

    public void SetCardScreen(){
        manager.OpenCardScreen(card);
    }
}

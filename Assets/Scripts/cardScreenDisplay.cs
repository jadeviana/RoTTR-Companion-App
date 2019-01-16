using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cardScreenDisplay : MonoBehaviour {

    public MKTCard card;
    public Image screenImage;

    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI value;
    public TextMeshProUGUI PopUpTitle;
    public TextMeshProUGUI PopUpValue;

    // Use this for initialization
    void Start () {
        screenImage.sprite = card.cardImage;

        title.text = card.cardName;
        description.text = card.description;
        value.text = card.credit.ToString();
        PopUpTitle.text = card.cardName;
        PopUpValue.text = card.credit.ToString();
    }

}

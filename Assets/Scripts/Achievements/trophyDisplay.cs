using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class trophyDisplay : MonoBehaviour {

    public Trophy trophy;

    public Image trophyImage;

    public TextMeshProUGUI trophyTitle;
    public TextMeshProUGUI trophyDescription;

    // Use this for initialization
    void Start () {
        trophyImage.sprite = trophy.trophyImage;

        trophyTitle.text = trophy.trophyName;
        trophyDescription.text = trophy.description;
    }

}

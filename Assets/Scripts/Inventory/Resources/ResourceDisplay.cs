using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceDisplay : MonoBehaviour {

	public ResourceItem item;

	public Image resourceIcon;
	public TextMeshProUGUI resourceName;
	public TextMeshProUGUI quantity;

	// Use this for initialization
	void Start () {
		resourceIcon.sprite = item.resourceImage;
		resourceName.text = item.resourceName;
		quantity.text = item.playerQuantity.ToString() + "/" + item.maximumQuantity.ToString();
		
		if(item.playerQuantity==0){
			quantity.text = "<#CF021B>" + item.playerQuantity.ToString() + "</color>" + "/" + item.maximumQuantity.ToString();
		}

	}
	
}

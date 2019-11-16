using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardScreenDisplay : MonoBehaviour {
	
	[SerializeField] private GameObject PopUpObject;
	[SerializeField] private CanvasGroup PopUp;


    [SerializeField] private TextMeshProUGUI PopUpQuantity;
	private int quantity = 1;
    [SerializeField] private Button increase;
	[SerializeField] private Button decrease;


	private void Update() {
		PopUpQuantity.text = quantity.ToString();
        if(quantity <=1){
			decrease.interactable = false;
		} else {
			decrease.interactable = true;
		}
    }

    public void decreaseQuantity(){
        --quantity;
    }
    public void increaseQuantity(){
        ++quantity;
    }


	public void OpenPopUp(){
		StartCoroutine(FadeIn(PopUp, PopUp.alpha, 1));
	}
	public void ClosePopUp(){
		StartCoroutine(FadeOut(PopUp, PopUp.alpha, 0));
	}

	public IEnumerator FadeIn(CanvasGroup modal, float start, float end, float lerpTime = 0.15f){
		PopUpObject.gameObject.SetActive(true);
		float _timeStartedLerping = Time.time;
		float timeSinceStarted;
		float percentageComplete;

		while(true){
			timeSinceStarted = Time.time - _timeStartedLerping;
			percentageComplete = timeSinceStarted/lerpTime;

			float currentValue = Mathf.Lerp(start,end,percentageComplete);
			modal.alpha = currentValue;

			if (percentageComplete >= 1) break;

			yield return new WaitForEndOfFrame();	
		}
	}
	public IEnumerator FadeOut(CanvasGroup modal, float start, float end, float lerpTime = 0.15f){
		float _timeStartedLerping = Time.time;
		float timeSinceStarted;
		float percentageComplete;

		while(true){
			timeSinceStarted = Time.time - _timeStartedLerping;
			percentageComplete = timeSinceStarted/lerpTime;

			float currentValue = Mathf.Lerp(start,end,percentageComplete);
			modal.alpha = currentValue;

			if (percentageComplete >= 1) break;

			yield return new WaitForEndOfFrame();	
		}
		
		PopUpObject.gameObject.SetActive(false);
		quantity = 1;	
	}
}

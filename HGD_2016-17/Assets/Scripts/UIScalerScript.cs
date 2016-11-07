using UnityEngine;
using System.Collections;

public class UIScalerScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        var xScale = Screen.width / originalScreenWidth;
        var yScale = Screen.height / originalScreenHeight;
        var rectTrans = GetComponent<RectTransform>();
        var size = rectTrans.sizeDelta;
        float originalWidth = size.x;
        float originalHeight = size.y;
        float originalX = rectTrans.anchoredPosition.x;
        float originalY = rectTrans.anchoredPosition.y;
        rectTrans.sizeDelta = new Vector2(originalWidth * xScale, originalHeight * yScale);
        rectTrans.anchoredPosition = new Vector2(originalX * xScale, originalY * yScale);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private float originalScreenWidth = 1024f;
    private float originalScreenHeight = 768f;
}

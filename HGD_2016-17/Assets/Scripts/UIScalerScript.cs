using UnityEngine;
using System.Collections;

public class UIScalerScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        scale.x = Screen.width / originalScreenWidth;
        scale.y = Screen.height / originalScreenHeight;
        scale.z = 1;
        var size = GetComponent<RectTransform>().sizeDelta;
        float originalWidth = size.x;
        float originalHeight = size.y;
        GetComponent<RectTransform>().sizeDelta = new Vector2(originalWidth * scale.x, originalHeight * scale.y);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private float originalScreenWidth = 1024;
    private float originalScreenHeight = 768f;
    private Vector3 scale;
}

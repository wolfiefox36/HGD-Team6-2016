using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PageNavigationScript : MonoBehaviour {

    private LevelSelectionManagerScript levelManager;
    public bool isIncrement;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindWithTag("UIManager").GetComponent<LevelSelectionManagerScript>();
        GetComponent<Button>().onClick.AddListener(delegate
        {
            levelManager.currentPage += isIncrement ? 1 : -1;
        });
	}
	
	// Update is called once per frame
	void Update () {
        var color = GetComponent<Image>().color;
        if (isIncrement)
        {
            if (levelManager.hasNextPage)
            {
                GetComponent<CanvasGroup>().alpha = 1f;    
                GetComponent<Button>().enabled = true;
            }
            else {
                GetComponent<CanvasGroup>().alpha = 0.5f;
                GetComponent<Button>().enabled = false;
            }
        }
        else {
            if (levelManager.hasPrevPage)
            {
                GetComponent<CanvasGroup>().alpha = 1f;
                GetComponent<Button>().enabled = true;
            }
            else {
                GetComponent<CanvasGroup>().alpha = 0.5f;
                GetComponent<Button>().enabled = false;
            }
        }
	}
}

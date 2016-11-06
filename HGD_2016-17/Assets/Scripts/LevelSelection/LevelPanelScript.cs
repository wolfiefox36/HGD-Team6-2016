using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelPanelScript : MonoBehaviour {


    public int levelCount;
    private LevelSelectionManagerScript levelManager;
    private Text levelNameText;
    private string sceneTitle;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindWithTag("UIManager").GetComponent<LevelSelectionManagerScript>();
        levelNameText = GetComponentInChildren<Text>();
        GetComponent<Button>().onClick.AddListener(delegate
        {
            SceneManager.LoadScene(sceneTitle);
        });
	}
	
	// Update is called once per frame
	void Update () {
        levelNameText.text = levelManager.currentPageLevels[levelCount].name;
        sceneTitle = levelManager.currentPageLevels[levelCount].sceneTitle;
	}
}

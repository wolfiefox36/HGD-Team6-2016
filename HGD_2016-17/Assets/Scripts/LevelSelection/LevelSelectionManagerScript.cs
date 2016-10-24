using UnityEngine;
using System.Collections.Generic;

public class LevelSelectionManagerScript : MonoBehaviour {

    public List<LevelInfo> levels;
    public int currentPage = 0;
    public int numberOfPages
    {
        get { return levels.Count / 6; }
    }
    public List<LevelInfo> currentPageLevels
    {
        get
        {
            return levels.GetRange(currentPage * 6, 6);
        }
    }
    public bool hasNextPage
    {
        get 
        {
            return currentPage + 1 < numberOfPages;
        }
    }
    public bool hasPrevPage
    {
        get
        {
            return currentPage > 0;
        }
    }

	// Use this for initialization
	void Start () {
        InitLevels();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void InitLevels() {
        levels = new List<LevelInfo>();
        levels.Add(new LevelInfo() { name = "1-1", sceneTitle = "MilesTutorial01" });
        levels.Add(new LevelInfo() { name = "1-2", sceneTitle = "MilesTutorial02" });
        levels.Add(new LevelInfo() { name = "1-3", sceneTitle = "MilesTutorial03" });
        levels.Add(new LevelInfo() { name = "1-4", sceneTitle = "MilesTutorial04" });
        levels.Add(new LevelInfo() { name = "1-5", sceneTitle = "MilesTutorial05" });
        levels.Add(new LevelInfo() { name = "1-6", sceneTitle = "MilesTutorial06" });
        levels.Add(new LevelInfo() { name = "2-1", sceneTitle = "MilesTutorial01" });
        levels.Add(new LevelInfo() { name = "2-2", sceneTitle = "MilesTutorial02" });
        levels.Add(new LevelInfo() { name = "2-3", sceneTitle = "MilesTutorial03" });
        levels.Add(new LevelInfo() { name = "2-4", sceneTitle = "MilesTutorial04" });
        levels.Add(new LevelInfo() { name = "2-5", sceneTitle = "MilesTutorial05" });
        levels.Add(new LevelInfo() { name = "2-6", sceneTitle = "MilesTutorial06" });
    }
}

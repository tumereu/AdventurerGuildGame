using UnityEngine;
using System.Collections;
using Assets.Scripts.Model;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {

    [SerializeField]
    private GameController gameController;
    [SerializeField]
    private GameObject dungeonSelectPanel;
    [SerializeField]
    private GameObject dungeonSelectButton;
    [SerializeField]
    private GameObject dungeonLayoutPanel;
    private DungeonInfoUpdater dungeonInfoUpdater;

	// Use this for initialization
	void Start () {
        this.gameController.guiController = this;
        this.dungeonInfoUpdater = this.dungeonLayoutPanel.GetComponent<DungeonInfoUpdater>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RefreshDungeons()
    {
        //Destroy all old dungeon buttons
        foreach (Transform child in this.dungeonSelectPanel.transform)
        {
            GameObject button = child.gameObject;
            Destroy(button);
        }
        //And Build current ones anew
        
        for (int i = 0; i < gameController.CurrentDungeons.Count; i++)
        {
            Dungeon dung  = gameController.CurrentDungeons[i];
            GameObject button = Instantiate(this.dungeonSelectButton) as GameObject;
            Text text = button.GetComponentInChildren<Text>();
            text.text = dung.GetDescription();
            button.transform.SetParent(dungeonSelectPanel.transform);
            button.GetComponent<DungeonSelectorScript>().index = i;
        }
    }

    public void DungeonSelected(int index)
    {
        Dungeon dungeon = this.gameController.CurrentDungeons[index];
        this.dungeonInfoUpdater.UpdateDungeon(dungeon);
    }
}

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

	// Use this for initialization
	void Start () {
        this.gameController.guiController = this;
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
        foreach (Dungeon dung in gameController.CurrentDungeons)
        {
            GameObject button = Instantiate(this.dungeonSelectButton) as GameObject;
            Text text = button.GetComponentInChildren<Text>();
            text.text = dung.GetDescription();
            button.transform.SetParent(dungeonSelectPanel.transform);
        }
    }
}

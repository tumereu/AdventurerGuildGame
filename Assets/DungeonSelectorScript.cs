using UnityEngine;
using System.Collections;

public class DungeonSelectorScript : MonoBehaviour {

    [HideInInspector]
    public int index;
    private GUIController guiController;

	// Use this for initialization
	void Start () {
        this.guiController = FindObjectOfType<GUIController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        guiController.DungeonSelected(index);
    }
}

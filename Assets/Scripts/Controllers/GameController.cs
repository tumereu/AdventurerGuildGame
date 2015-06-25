using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Model;

public class GameController : MonoBehaviour {

    private LinkedList<Dungeon> currentDungeons;
    [HideInInspector]
    public GUIController guiController;

	// Use this for initialization
	void Start () {
        this.currentDungeons = new LinkedList<Dungeon>();
        this.InitializeDungeons();
	}

    void InitializeDungeons()
    {
        for (int i = 0; i < 25; i++)
        {
            this.currentDungeons.AddLast(DungeonGenerator.generateRandomDungeon(1));
            this.guiController.RefreshDungeons();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    internal LinkedList<Dungeon> CurrentDungeons
    {
        get { return currentDungeons; }
        set { currentDungeons = value;  }
    }
}

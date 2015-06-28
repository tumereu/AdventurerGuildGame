using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Model;

class DungeonInfoUpdater : MonoBehaviour {

    [SerializeField]
    private Text dungeonInfoText;
    [SerializeField]
    private GameObject dungeonPathPanel;
    [SerializeField]
    private GameObject dungeonEncounterPrefab;
    [SerializeField]
    private GameObject bossEncounterPrefab;

    private Dungeon currentDungeon;
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateDungeon(Dungeon dungeon)
    {
        this.currentDungeon = dungeon;
        foreach (Transform child in this.dungeonPathPanel.transform)
        {
            Destroy(child.gameObject);
        }
        RectTransform panelRect = this.dungeonPathPanel.transform as RectTransform;
        //Go through all the enconters and position them on the encounter panel
        foreach (DungeonEncounter enc in dungeon.Encounters) {
            GameObject encounterObject = Instantiate(this.dungeonEncounterPrefab) as GameObject;
            Image img = encounterObject.GetComponent<Image>();
            img.sprite = Resources.Load<Sprite>(enc.IconName);
            ToolTipScript tts = encounterObject.GetComponent<ToolTipScript>();
            tts.Text = enc.Description;
            encounterObject.transform.SetParent(this.dungeonPathPanel.transform);
            RectTransform imageRect = encounterObject.transform as RectTransform;
            imageRect.anchoredPosition = new Vector2(panelRect.sizeDelta.x * enc.Location, 0f);
        }
        GameObject boss = Instantiate(this.bossEncounterPrefab) as GameObject;
        boss.transform.SetParent(this.dungeonPathPanel.transform);
        RectTransform rect = boss.transform as RectTransform;
        rect.anchoredPosition = new Vector2(panelRect.sizeDelta.x, 0f);
    }
}

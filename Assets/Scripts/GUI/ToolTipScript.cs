using UnityEngine;
using System.Collections;
using Assets.Scripts.Model.Abilities.Boss;

public class ToolTipScript : MonoBehaviour {

    [Multiline]
    public string text;
    private GUIContent content;
    private Vector2 contentSize;
    public GUISkin style;
    public bool drawToolTip;

	// Use this for initialization
	void Start () {
        Rampage rampage = new Rampage();
        this.text = rampage.GetInfo();
        this.content = new GUIContent(text);
        this.contentSize = style.box.CalcSize(content);
	}

    void OnGUI()
    {
        if (drawToolTip)
        {
            Vector2 offSet = Vector2.zero;
            Vector2 loc = new Vector2(Input.mousePosition.x + 10, Screen.height - Input.mousePosition.y + 15);
            if (loc.x + this.contentSize.x > Screen.width)
            {
                offSet = new Vector2((Screen.width - loc.x  - this.contentSize.x), offSet.y);
            }
            if (loc.y + this.contentSize.y > Screen.height)
            {
                offSet = new Vector2(offSet.x, Screen.height - loc.y - this.contentSize.y);
            }
            GUI.Box(new Rect(loc.x + offSet.x, loc.y + offSet.y, this.contentSize.x, this.contentSize.y),
                this.content, style.box);
        }
    }

    public void MouseEntered()
    {
        this.drawToolTip = true;
    }

    public void MouseExited()
    {
        this.drawToolTip = false;
    }
}

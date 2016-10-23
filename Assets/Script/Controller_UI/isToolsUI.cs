using UnityEngine;
using System.Collections;

public class isToolsUI : MonoBehaviour {

    private isPickaxeUI PickaxeUI;
    private isHammerUI HammerUI;
    // private isDorillUI DorillUI;
    // private isBombUI BombUI;

    private bool isPickaxe;
    private bool isHammer;
    private bool isDorill;
    private bool isBomb;

	// Use this for initialization
	void Start () {
        PickaxeUI = GameObject.Find("UI_Pickaxe").GetComponent<isPickaxeUI>();
        HammerUI = GameObject.Find("UI_Hammer").GetComponent<isHammerUI>();
        // DorillUI = GameObject.Find("UI_Dorill").GetComponent<isDorillUI>();
        // BombUI = GameObject.Find("UI_Bomb").GetComponent<isBombUI>();

        isPickaxe = true;
        isHammer = true;
        isDorill = true;
        isBomb = true;
	}

	// Update is called once per frame
	void Update () {

	}

    public void ToolManager(string tag){
        switch(tag){
            case "tagPickaxe":
                setPickaxe();
                break;
            case "tagHammer":
                setHammer();
                break;
            case "tagDorill":
                setDorill();
                break;
            case "tagBomb":
                setBomb();
                break;
        }
    }

    private void setPickaxe(){
        if(isPickaxe){
            PickaxeUI.setActive_shadow(isPickaxe = false);
            HammerUI.setActive_shadow(isHammer = true);
        }else{
            PickaxeUI.setActive_shadow(isPickaxe = true);
        }

    }

    private void setHammer(){
        if(isHammer){
            PickaxeUI.setActive_shadow(isPickaxe = true);
            HammerUI.setActive_shadow(isHammer = false);
        }else{
            HammerUI.setActive_shadow(isHammer = true);
        }

    }

    private void setDorill(){
        // DorillUI.setActive_shadow(isDorill);
        gameObject.SetActive (false);
    }

    private void setBomb(){
        // BombUI.setActive_shadow(isBomb);
        gameObject.SetActive (false);
    }

}

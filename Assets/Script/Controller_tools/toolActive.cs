using UnityEngine;
using System.Collections;

public class toolActive : MonoBehaviour {

    GameObject isPickaxe;
    GameObject isHammer;
    GameObject isDorill;
    GameObject isBomb;

	// Use this for initialization
	void Start () {
        isPickaxe = GameObject.Find("isPickaxe");
        isHammer = GameObject.Find("isHammer");
        isDorill = GameObject.Find("isDorill");
        isBomb = GameObject.Find("isBomb");

        isPickaxe.SetActive(false);
        isHammer.SetActive(false);
        isDorill.SetActive(false);
        isBomb.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}

    public void setActive_tool(string tag, bool trigger){
        if(trigger){
            OnActive(tag, trigger);
        }else{
            OffActive(tag, trigger);
        }

    }

    private void OnActive(string tag, bool trigger){
        switch(tag){
            case "tagPickaxe":
                isPickaxe.SetActive(trigger);
                break;
            case "tagHammer":
                isHammer.SetActive(trigger);
                break;
            case "tagDorill":
                isDorill.SetActive(trigger);
                break;
            case "tagBomb":
                isBomb.SetActive(trigger);
                break;
        }
    }

    private void OffActive(string tag, bool trigger){

        switch(tag){
            case "tagPickaxe":
                isPickaxe.SetActive(trigger);
                break;
            case "tagHammer":
                isHammer.SetActive(trigger);
                break;
            case "tagDorill":
                isDorill.SetActive(trigger);
                break;
            case "tagBomb":
                isBomb.SetActive(trigger);
                break;
        }

    }

}

using UnityEngine;
using System.Collections;

public class isHammerUI : MonoBehaviour {

    private isToolsUI isTrigger;
    private toolActive isActive;

    private GameObject obj;

    // Use this for initialization
    void Start () {
        isTrigger = GameObject.Find("UI_Manager").GetComponent<isToolsUI>();
        isActive = GameObject.Find("isActive").GetComponent<toolActive>();

        obj = GameObject.Find("isShadow_h");
    }

    // Update is called once per frame
    void Update () {

    }

    void OnMouseDown(){
        isTrigger.ToolManager(gameObject.tag);
    }

    public void setActive_shadow(bool trigger){

        obj.SetActive(trigger);
        if(trigger){
            isActive.setActive_tool(gameObject.tag, false);
        }else{
            isActive.setActive_tool(gameObject.tag, true);
        }

    }

}
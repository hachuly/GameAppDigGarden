using UnityEngine;
using System.Collections;
using System;


public class toolPickaxe : MonoBehaviour {

    private soundActive setAudio;
    private hitPoint def;
    private hitPoint penalty;
    private findJewely isActive;

    private int str;

	// Use this for initialization
	void Start () {
        setAudio = GameObject.Find("isSE").GetComponent<soundActive>();
        str = 5;
	}

    public void OnMouseUp() {
        Pickaxe();

    }

    public void Pickaxe(){
        int layer = 1 << 8;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 ray_position = (Vector2)ray.origin;
        RaycastHit2D hit;

        try{
            hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
            playAction(hit);
        }catch(NullReferenceException e){}



    }

    private void playAction(RaycastHit2D ray){
        if(ray.collider.gameObject.tag == "tagSand"
            || ray.collider.gameObject.tag == "tagStone"){
            setAudio.setActive(ray.collider.gameObject.tag);
            def = ray.collider.gameObject.GetComponent<hitPoint>();
            def.attackTratum(str);
        }else{
            if(ray.collider.gameObject.tag == "tagJewelry"){
                penalty = ray.collider.gameObject.GetComponent<hitPoint>();
                penalty.isPenaltyTrigger();
            }

        }

    }

}
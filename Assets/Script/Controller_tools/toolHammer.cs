using UnityEngine;
using System;
using System.Collections;

public class toolHammer : MonoBehaviour {

    private soundActive setAudio;
    private hitPoint def;
    private hitPoint penalty;

    private int str;

    void Start(){
        setAudio = GameObject.Find("isSE").GetComponent<soundActive>();

        str = 2;
    }

    public void OnMouseUp() {
        Hammer();
    }

    public void Hammer(){
        int layer = 1 << 8;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 ray_position = (Vector2)ray.origin;
        RaycastHit2D hit;

        try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
            playAction(hit);
        }catch(NullReferenceException ex){}
        try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + -0.015f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
            playAction(hit);
        }catch(NullReferenceException ex){}
        try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f, ray_position.y + -0.015f), Vector2.zero, 1, layer);
            playAction(hit);
        }catch(NullReferenceException ex){}
        try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + -0.015f, ray_position.y + -0.015f), Vector2.zero, 1, layer);
            playAction(hit);
        }catch(NullReferenceException ex){}

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

using UnityEngine;
using System.Collections;
using System;


public class toolPickaxe : MonoBehaviour {

    private hitPoint def;

    private int str;

	// Use this for initialization
	void Start () {
        str = 5;
	}

    public void OnMouseUp() {
        Pickaxe();
    }

    public void Pickaxe(){
        try{
            int layer = 1 << 8;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector2 ray_position = (Vector2)ray.origin;
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, Vector2.zero, 1, layer);
            def = hit.collider.gameObject.GetComponent<hitPoint>();
            def.attackTratum(str);

        }catch(NullReferenceException ex){
            Debug.Log("error");
        }
    }

}

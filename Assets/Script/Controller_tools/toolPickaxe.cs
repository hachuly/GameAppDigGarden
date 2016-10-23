using UnityEngine;
using System.Collections;
using System;


public class toolPickaxe : MonoBehaviour {

	// Use this for initialization
	void Start () {

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
            Destroy(hit.collider.gameObject);

        }catch(NullReferenceException ex){
            Debug.Log("error");
        }
    }

}

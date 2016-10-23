using UnityEngine;
using System;
using System.Collections;

public class toolHammer : MonoBehaviour {

    void Start(){

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
                Debug.Log(hit.collider.gameObject.name);
                Destroy(hit.collider.gameObject);
        }catch(NullReferenceException ex){
        }try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + -0.015f, ray_position.y + 0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);
        }catch(NullReferenceException ex){
        }
        try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + 0.015f, ray_position.y + -0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);
        }catch(NullReferenceException ex){
        }
        try{
            hit = Physics2D.Raycast(new Vector2(ray_position.x + -0.015f, ray_position.y + -0.015f), Vector2.zero, 1, layer);
            Debug.Log(hit.collider.gameObject.name);
            Destroy(hit.collider.gameObject);
        }catch(NullReferenceException ex){
        }

    }

}

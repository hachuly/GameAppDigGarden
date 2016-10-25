using UnityEngine;
using System;
using System.Collections;

public class setParent : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public void setting(GameObject obj){
        try{
            obj.transform.parent = gameObject.transform;
        }catch(NullReferenceException e){

        }

    }

}

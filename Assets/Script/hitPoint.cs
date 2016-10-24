using UnityEngine;
using System.Collections;

public class hitPoint : MonoBehaviour {

    private isScore adder;

    public int def;
    public int yen;

	// Use this for initialization
	void Start () {
        adder = GameObject.Find("Score").GetComponent<isScore>();
	}

	// Update is called once per frame
	void Update () {

	}

    public void attackTratum(int str){
        def -= str;
        if(def < 0){
            adder.addScore(yen);
            Destroy(gameObject);
        }
    }
}

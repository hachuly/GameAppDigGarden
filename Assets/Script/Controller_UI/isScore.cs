using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class isScore : MonoBehaviour {

    private GameObject yen;

	// Use this for initialization
	void Start () {
        this.yen = gameObject;
	}

	// Update is called once per frame
	void Update () {

	}

    public void addScore(int i){

    }

    public void showScore(int i){
        this.yen.GetComponent<Text>().text = "a";
    }
}

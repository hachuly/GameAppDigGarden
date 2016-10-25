using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class isResult : MonoBehaviour {

    private GameObject score;
    private isScore show;

	// Use this for initialization
	void Start () {
        score = gameObject;
        show = GameObject.Find("Score").GetComponent<isScore>();
	}

	// Update is called once per frame
	void Update () {

	}

    public void getScone(){
        score.GetComponent<Text>().text = show.inYen();
    }
}

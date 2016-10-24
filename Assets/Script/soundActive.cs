using UnityEngine;
using System.Collections;

public class soundActive : MonoBehaviour {

    private GameObject soundStone;
    private GameObject soundSand;

    private AudioSource playStone;
    private AudioSource playSand;

	// Use this for initialization
	void Start () {
        soundSand = GameObject.Find("soundSand");
        soundStone = GameObject.Find("soundStone");

        playSand = soundSand.GetComponent<AudioSource>();
        playStone = soundStone.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

	}

    public void setActive(string tag){
        switch(tag){
            case "tagSand": playSand.PlayOneShot(playSand.clip);
                break;
            case "tagStone": playStone.PlayOneShot(playStone.clip);
                break;
        }
    }
}

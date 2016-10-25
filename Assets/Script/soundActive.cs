using UnityEngine;
using System.Collections;

public class soundActive : MonoBehaviour {

    private GameObject soundStone;
    private GameObject soundSand;
    private GameObject soundJewelry;
    private GameObject soundMoney;

    private AudioSource playStone;
    private AudioSource playSand;
    private AudioSource playJewelry;
    private AudioSource playMoney;

	// Use this for initialization
	void Start () {
        soundSand = GameObject.Find("soundSand");
        soundStone = GameObject.Find("soundStone");
        soundJewelry = GameObject.Find("soundJewelry");
        soundMoney = GameObject.Find("soundMoney");

        playSand = soundSand.GetComponent<AudioSource>();
        playStone = soundStone.GetComponent<AudioSource>();
        playJewelry = soundJewelry.GetComponent<AudioSource>();
        playMoney = soundMoney.GetComponent<AudioSource>();
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
            case "tagJewelry": playJewelry.PlayOneShot(playJewelry.clip);
                break;
            case "tagMoney": playMoney.PlayOneShot(playMoney.clip);
                break;
        }
    }
}

using UnityEngine;
using System.Collections;

public class hitPoint : MonoBehaviour {

    private nextWave end;
    private isScore adder;

    public int def;
    public int yen;

    private bool trigger;

	// Use this for initialization
	void Start () {
        adder = GameObject.Find("Score").GetComponent<isScore>();
        end = GameObject.Find("Script_StratumManager").GetComponent<nextWave>();
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

    public void isPenalty(){
        def--;
        yen /= 2;
        if(def < 0){
            Destroy(gameObject);
            end.reset();
        }

    }
    public void getJewelry(){
        adder.addScore(yen);
        trigger = true;
        end.reset();
    }

    public void isAnotherPenalty(){
        def--;
        yen /=2;
        adder.getPenalty(yen.ToString());
        if(def < 0){
            Destroy(gameObject);
            end.reset();
        }
    }

    public void isPenaltyTrigger(){
        if(trigger){
            isAnotherPenalty();
        }else{
            isPenalty();
        }

    }

}

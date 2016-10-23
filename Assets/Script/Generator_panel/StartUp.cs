using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

    public GameObject Prefab;
    private GameObject[] Generator_main;
    private Vector2 Base_position;
    private float Z_position;

	// Use this for initialization
	void Start () {
        Generator_main = new GameObject[42];
        Base_position = new Vector2(-0.135f, -0.085f);
        switch(Prefab.gameObject.tag){
            case "Mud":
                Z_position = 0.0f;
                break;
            case "Jewely":
                Z_position = 0.1f;
                break;
            case "Sand":
                Z_position = 0.2f;
                break;
            case "Stone_b":
                Z_position = 0.3f;
                break;
            case "Stone":
                Z_position = 0.4f;
                break;
        }
        for(int n = 0; n < 6; n++){
            for(int i = 0; i < 7; i++){
                Generator_main[i] = Instantiate(Prefab) as GameObject;
                Generator_main[i].transform.position = new Vector3(Base_position.x + i*0.03f ,Base_position.y + n*0.03f, -Z_position);
                Generator_main[i].name = Generator_main[i].name + n.ToString() + i.ToString();
            }
        }
	}

	// Update is called once per frame
	void Update () {

	}
}

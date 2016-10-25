using UnityEngine;
using System.Collections;

public class StartUp : MonoBehaviour {

    private setParent parent;

    public GameObject Prefab;
    private GameObject[] Generator_main;
    private Vector2 Base_position;
    private float Z_position;

	// Use this for initialization
	void Start () {
        parent = gameObject.GetComponent<setParent>();
        Generator_main = new GameObject[42];
        Base_position = new Vector2(-0.135f, -0.085f);
        switch(Prefab.gameObject.tag){
            case "tagMud":
                Z_position = 0.0f;
                break;
            case "tagJewely":
                Z_position = 0.1f;
                break;
            case "tagSand":
                Z_position = 0.2f;
                break;
            case "tagStone_b":
                Z_position = 0.3f;
                break;
            case "tagStone":
                Z_position = 0.4f;
                break;
        }

        if(Prefab.gameObject.tag == "tagStone"){
            for(int n = 0; n < 6; n++){
                for(int i = 0; i < 7; i++){
                    if(Random.Range(0, 2) == 1){
                        Generator_main[i] = Instantiate(Prefab) as GameObject;
                        Generator_main[i].transform.position = new Vector3(Base_position.x + i*0.03f ,Base_position.y + n*0.03f, -Z_position);
                        Generator_main[i].name = Generator_main[i].name + n.ToString() + i.ToString();
                        parent.setting(Generator_main[i]);
                    }
                }
            }
        }else if(Prefab.gameObject.tag == "tagJewelry"){
            if(Prefab.gameObject.name == "L_Ruby"
            || Prefab.gameObject.name == "L_Sapphire"
            || Prefab.gameObject.name == "L_Emerald"
            ){  Base_position = new Vector2(-0.105f, -0.055f);
                Generator_main[0] = Instantiate(Prefab) as GameObject;
                Generator_main[0].transform.position = new Vector3(Base_position.x + Random.Range(1,5)*0.03f ,Base_position.y + Random.Range(1,4)*0.03f, -Z_position);
                Generator_main[0].transform.parent = gameObject.transform;
            }else
            if(Prefab.gameObject.name == "M_Ruby"
            || Prefab.gameObject.name == "M_Sapphire"
            || Prefab.gameObject.name == "M_Emerald"
            ){  Base_position = new Vector2(-0.12f, -0.07f);
                Generator_main[0] = Instantiate(Prefab) as GameObject;
                Generator_main[0].transform.position = new Vector3(Base_position.x + Random.Range(1,6)*0.03f ,Base_position.y + Random.Range(1,5)*0.03f, -Z_position);
                Generator_main[0].transform.parent = gameObject.transform;
            }else
            if(Prefab.gameObject.name == "S_Ruby"
            || Prefab.gameObject.name == "S_Sapphire"
            || Prefab.gameObject.name == "S_Emerald"){
                Generator_main[0] = Instantiate(Prefab) as GameObject;
                Generator_main[0].transform.position = new Vector3(Base_position.x + Random.Range(1,7)*0.03f ,Base_position.y + Random.Range(1,6)*0.03f, -Z_position);
                Generator_main[0].transform.parent = gameObject.transform;

            }
        }else{
            for(int n = 0; n < 6; n++){
                for(int i = 0; i < 7; i++){
                    Generator_main[i] = Instantiate(Prefab) as GameObject;
                    Generator_main[i].transform.position = new Vector3(Base_position.x + i*0.03f ,Base_position.y + n*0.03f, -Z_position);
                    Generator_main[i].name = Generator_main[i].name + n.ToString() + i.ToString();
                    parent.setting(Generator_main[i]);
                }

            }

        }

	}

	// Update is called once per frame
	void Update () {

	}
}

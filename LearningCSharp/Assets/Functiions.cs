using UnityEngine;
using System.Collections;

public class Functiions : MonoBehaviour {
    int hp = 100;
    int attackDamage = 25;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void attack()
    {
        hp -= attackDamage;
        Debug.Log(hp);
    }
    public void heal()
    {
        int hpx = randomGenerator();
        hp += hpx;
        Debug.Log(hp + "  " + hpx );
    }
    int randomGenerator()
    {
        return Random.Range(2, 10);
    }
}

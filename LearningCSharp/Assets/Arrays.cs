using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

    public GameObject cubePrefabs;

    GameObject[] cubes = new GameObject[5];
    Color[] colours = { Color.green,Color.red,Color.blue,Color.yellow,Color.magenta};

	// Use this for initialization
	void Start () {
        for (int i = 0; i < cubes.Length; i++)
        {
            GameObject cube = Instantiate(cubePrefabs);
            cubes[i] = cube;
            cube.transform.position = new Vector3((i*2),0,0);
            cubes[i].GetComponent<Renderer>().material.color = colours[i];
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

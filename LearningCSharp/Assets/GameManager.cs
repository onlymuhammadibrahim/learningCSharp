using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Zombie zombie = new Zombie();
        Player player = new Player();

        player.TakeDamage(zombie.Attack());
        player.TakeDamage(zombie.AcidPukeAttack());

        player.Die();


        Zombie[] zombies = new Zombie[100];

        for (int i = 0; i < zombies.Length; i++)
        {
            zombies[i] = new Zombie();
            Debug.Log("Creating zombie #: " + i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

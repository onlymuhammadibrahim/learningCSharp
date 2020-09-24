﻿using UnityEngine;
using System.Collections;

public class Zombie : Humanoid {

    private int poisionDamage = 3;

    public override void Move()
    {
        base.Move();
        transform.Translate(Vector3.left * (3 * Time.deltaTime));
    }
	
    public int AcidPukeAttack()
    {
        return attackDamage + poisionDamage;
    }
}

using UnityEngine;
using System.Collections;

public class Player : Humanoid {

    private int spinAttackDamage = 30;



    public override int Attack()
    {
        return attackDamage + spinAttackDamage;
    }
}

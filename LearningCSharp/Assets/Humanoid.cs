using UnityEngine;
using System.Collections;

public class Humanoid : MonoBehaviour {

    private int health;
    protected int attackDamage;
    private int movementSpeed;

    public void TakeDamage(int damage_to_take)
    {
        health -= damage_to_take;
    }

    public virtual int Attack()
    {
        return attackDamage;
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void Die()
    {

    }
}

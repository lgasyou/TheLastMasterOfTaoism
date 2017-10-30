using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTarget : MonoBehaviour {
    public GameObject attacker = null;

    public void Attack(GameObject receiver) {
        Entity.Creative a = attacker.GetComponent<Entity.Creative>();
        int damage = a.Attack();
        Entity.Creative r = receiver.GetComponent<Entity.Creative>();
        r.ReceiveDamage(damage);
    }
}

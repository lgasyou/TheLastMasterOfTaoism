using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour {
    List<Entity.Creative> units = new List<Entity.Creative>();

    // Use this for initialization
    void Start () {
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("PlayerUnit");
        foreach (GameObject playerObject in playerObjects) {
            Entity.Player player = playerObject.GetComponent<Entity.Player>();
            units.Add(player);
        }
        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("EnemyUnit");
        foreach (GameObject enemyObject in enemyObjects) {
            Entity.Monster enemy = enemyObject.GetComponent<Entity.Monster>();
            units.Add(enemy);
        }

        NextTurn();
    }

    public void NextTurn() {
        Entity.Creative currentUnit = units[0];
        units.Remove(currentUnit);
        if (currentUnit.IsAlive()) {
            // Fight here
            units.Add(currentUnit);
            return;
        }
        NextTurn();
    }
}

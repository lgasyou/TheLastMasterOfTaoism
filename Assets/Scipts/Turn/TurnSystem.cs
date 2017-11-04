using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Entity;

namespace Turn {
    public class TurnSystem : MonoBehaviour {
        List<Monster> units = new List<Monster>();
        Player player;

        // Use this for initialization
        void Start() {
            GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("PlayerUnit");
            foreach (GameObject playerObject in playerObjects) {
                player = playerObject.GetComponent<Player>();
            }
            GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("EnemyUnit");
            foreach (GameObject enemyObject in enemyObjects) {
                Monster enemy = enemyObject.GetComponent<Monster>();
                units.Add(enemy);
            }
        }

        public void MonsterTurn() {
            Monster monster = units[0];
            units.Remove(monster);
            while (monster.IsAlive()) {
                Attack(monster, player);
                units.Add(monster);
                monster = units[0];
            }
        }

        public void PlayerAttack() {
            Attack(player, units[0]);
        }

        public void PlayerUse() {

        }

        public void PlayerBackpack() {
            
        }

        public void PlayerFlee() {
            SceneManager.LoadScene("QingNiuTown");
        }

        void Attack(Creative attacker, Creative receiver) {
            int damage = attacker.Attack();
            receiver.ReceiveDamage(damage);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Entity;

namespace Turn {
    public class TurnSystem : MonoBehaviour {
        Monster monster;
        Player player;

        // Use this for initialization
        void Start() {
            GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("PlayerUnit");
            foreach (GameObject playerObject in playerObjects) {
                player = playerObject.GetComponent<Player>();
            }
            GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag("EnemyUnit");
            foreach (GameObject enemyObject in enemyObjects) {
                monster = enemyObject.GetComponent<Monster>();
            }
        }

        public void MonsterTurn() {
            if (monster.IsAlive()) {
                Attack(monster, player);
            }
        }

        public void PlayerAttack() {
            Attack(player, monster);
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

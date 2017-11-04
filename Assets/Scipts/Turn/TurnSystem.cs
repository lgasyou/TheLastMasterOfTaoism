using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Entities;

namespace Turn {
    public class TurnSystem : MonoBehaviour {
        Monster monster;
        Player player;

        // Use this for initialization
        void Start() {
            player = Player.Instance;
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
            MonsterTurn();
        }

        public void PlayerUseSkill() {
            MonsterTurn();
        }

        public void PlayerFlee() {
            SceneManager.LoadScene("QingNiuTown");
        }

        void Attack(Creative attacker, Creative receiver) {
            int damage = attacker.Attack();
            receiver.ReceiveDamage(damage);
            print("taking damage!");
        }
    }
}

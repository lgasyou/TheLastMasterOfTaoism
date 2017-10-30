using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity {
    public class Monster : Creative {
        public List<Skill> skills = new List<Skill>();  // 技能
        public Package package = new Package();         // 掉落物背包
        public Equipment equipment = new Equipment();   // 装备
        public int level;                               // 怪物等级

        // 可以使用随机数初始化怪物的背包
        void InitMonsterPackage() {
            throw new System.NotImplementedException();
        }

        // Use this for initialization
        void Start() {
            InitMonsterPackage();
        }

        public override int Attack() {
            int i = Random.Range(0, skills.Count);
            return (i == skills.Count) ? attack : skills[i].factor * attack;
        }

        // 死亡时掉落物品
        Package DropOut() {
            return package;
        }
    }
}

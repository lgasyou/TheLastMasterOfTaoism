using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity {
    public class Monster : Creative {
        public Skill skills = new Skill();              // 技能
        public Package package = new Package();         // 掉落物背包
        public Equipment equipment = new Equipment();   // 装备
        public int level;                               // 怪物等级

        // 可以使用随机数初始化怪物的背包
        void InitMonsterPackage() {
            throw new System.NotImplementedException();
        }

        // 死亡时掉落物品
        Package DropOut() {
            return package;
        }

        // Use this for initialization
        void Start() {
            InitMonsterPackage();
        }

        // Update is called once per frame
        void Update() {

        }
    }
}

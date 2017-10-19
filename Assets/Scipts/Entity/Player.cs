using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity {
    // 目前希望将等级与升级条件存入文件之中，游戏运行时读取
    public class PlayerLevel {
        string level;

        // 目前希望升级时传入背包扣减材料
        void LevelUp(Package package) {
            throw new System.NotImplementedException();
        }
    }

    public class Player : Creative {
        public string playerName;                       // ID
        public int energy;                              // 能量点数
        public int meridian;                            // 经脉-TODO
        public Package package = new Package();         // 背包
        public Equipment equipment = new Equipment();   // 装备
        public PlayerLevel level = new PlayerLevel();   // 玩家等级

        void Attack(Creative other) {
            throw new System.NotImplementedException();
        }

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    }
}

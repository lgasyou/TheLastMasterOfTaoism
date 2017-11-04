using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 暂时放置在这
// 装备与背包系统相似，可以重用Package的代码
public class Equipment : Package {

}

// 暂时放置在这
public class Skill {
    public string name;                 // 名称
    public string description;          // 介绍
    public int manaCost;                // 耗蓝
    public int factor;                  // 攻击加成
}

namespace Entities {
    // 生物类
    public abstract class Creative : MonoBehaviour {
        public string kind;             // 生物种类
        public string creativeName;     // ID
        public int health;              // 生命点数
        public int attack;              // 攻击力
        public float resistance;          // 抗性

        public bool IsAlive() {
            return health > 0;
        }

        public void ReceiveDamage(int damage) {
            health -= (int)((1 - resistance) * damage);
        }

        public abstract int Attack();

    }
}

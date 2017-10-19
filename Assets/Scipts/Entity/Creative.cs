using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 暂时放置在这
// 装备与背包系统相似，可以重用PackageController的代码
public class Equipment {
    Package equipment = new Package();
}

// 暂时放置在这
public class Skill {

}

namespace Entity {
    // 生物类
    public class Creative : MonoBehaviour {
        public string kind;             // 生物种类
        public string creativeName;     // ID
        public int health;              // 生命点数
        public int attack;              // 攻击力

        public bool IsAlive() {
            return health > 0;
        }

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    }
}

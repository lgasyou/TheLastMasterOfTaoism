using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities {
    // 交易点
    public class TransactionPoint : Creative {
        public Package package = new Package();    // 可交易物品列表

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        // 交易者不应该攻击
        public override int Attack() {
            throw new System.NotSupportedException();
        }
    }
}

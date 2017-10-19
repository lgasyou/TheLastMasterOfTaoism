#define UNIT_TEST
#undef UNIT_TEST

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 背包物品基类
public class Item {
    public string name;         // 名称
    public string decription;   // 描述
    public string rarity;       // 稀有度
    public string quality;      // 品质
    public bool useable;        // 是否可以使用
}

// 消耗品
public class Comsumable : Item {
    public int lastUseTime;     // 剩余使用次数
    public int maxUseTime;      // 最大使用次数
    public string kind;         // 类型
}

public class Package : MonoBehaviour {
    public const int defaultPackageSize = 10;

    int packageLevel = 1;
    List<Item> items = new List<Item>();
    int usedSize = 0;

    public Package() {
        Extend(defaultPackageSize);
    }

    public bool IsFull() {
        return usedSize == items.Count;
    }

    public void LevelUp() {

    }

    public Item Get(int index) {
        return items[index];
    }

    public void Remove(int index) {
        --usedSize;
        items[index] = null;
    }

    public void Put(int index, Item item) {
        if (items[index] == null) {
            ++usedSize;
        }
        items[index] = item;
    }

    public void Put(Item item) {
        for (int i = 0; i != items.Count; ++i) {
            if (items[i] == null) {
                ++usedSize;
                items[i] = item;
                return;
            }
        }
        Debug.Log("Package is full!");
    }

    void Extend(int size) {
        for (int i = 0; i != size; ++i) {
            items.Add(null);
        }
    }

    // TODO - 没有经过测试！
    public void Merge(Package other) {
        items.AddRange(other.items);
        throw new System.NotImplementedException();
    }

#if (UNIT_TEST)
    public void Start() {
        Debug.Log("PackageController-Test-Begin");
        UnitTest();
        Debug.Log("PackageController-Test-End");
    }

    void UnitTest() {
        for (int i = 0; i != items.Count + 1; ++i) {
            Item item1 = new Item() {
                name = "ForTest"
            };
            if (!IsFull()) {
                Put(item1);
            } else {
                print("Is Full!");
            }
            print("Used Size:" + usedSize);
        }

        print(Get(0).name);
        print("Used Size:" + usedSize);

        Extend(2);
        Put(10, new Item() {
            name = "Added",
        });
        print("Used Size:" + usedSize);

        Put(0, new Item() {
            name = "Added",
        });
        print("Used Size:" + usedSize);

        Remove(1);
        print(Get(1).name);
    }
#endif
}

#define UNIT_TEST
#undef UNIT_TEST

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 背包物品基类
public class PackageItem {
    public string name;         // 名称
    public string decription;   // 描述
    public string quality;      // 品质
    public bool useable;        // 是否可以使用
    public int maxNumber;       // 每格最大叠加数
}

// 消耗品
public class Comsumable : PackageItem {
    public int lastUseTime;     // 剩余使用次数
    public int maxUseTime;      // 最大使用次数
    public string kind;         // 类型
}

public class Package {
    public const int defaultPackageSize = 32;

    int packageLevel = 1;
    List<PackageItem> items = new List<PackageItem>();
    int usedSize = 0;

    public Package(int size = defaultPackageSize) {
        Extend(size);
    }

    public bool IsFull() {
        return usedSize == items.Count;
    }

    public void LevelUp() {

    }

    public PackageItem Get(int index) {
        return items[index];
    }

    public void Remove(int index) {
        --usedSize;
        items[index] = null;
    }

    public void Put(int index, PackageItem item) {
        if (items[index] == null) {
            ++usedSize;
        }
        items[index] = item;
    }

    public void Put(PackageItem item) {
        for (int i = 0; i != items.Count; ++i) {
            if (items[i] == null) {
                ++usedSize;
                items[i] = item;
                return;
            }
        }
        Debug.Log("Package is full!");
    }

    // TODO - 没有经过测试！
    public void Merge(Package other) {
        items.AddRange(other.items);
        throw new System.NotImplementedException();
    }

    void Extend(int size) {
        for (int i = 0; i != size; ++i) {
            items.Add(null);
        }
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

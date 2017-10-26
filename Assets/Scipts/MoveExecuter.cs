using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExecuter : MonoBehaviour {
    public void BagButton(int indexInPackage) {
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj == null) {
            Debug.Log("Cannot find player");
            return;
        }
        Entity.Player player = playerObj.GetComponent<Entity.Player>();
        PackageItem item = player.package.Get(indexInPackage);
        if (item != null) {
            if (!player.equipment.IsFull()) {
                player.equipment.Put(item);
            }
        }
        print(indexInPackage);
    }

    public void EquipmentButton(int indexInEquipment) {
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj == null) {
            Debug.Log("Cannot find player");
            return;
        }
        Entity.Player player = playerObj.GetComponent<Entity.Player>();
        PackageItem item = player.equipment.Get(indexInEquipment);
        if (item != null) {
            if (!player.package.IsFull()) {
                player.package.Put(item);
            }
        }
        print(indexInEquipment);
    }
}

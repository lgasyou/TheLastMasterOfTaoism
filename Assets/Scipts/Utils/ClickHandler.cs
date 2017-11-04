using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//public class CClickHandler : MonoBehaviour {
//	// Use this for initialization
//	void Start () {
//        Button button = GetComponent<Button>();
//        button.onClick.AddListener(OnClicked);
//	}

//    public void OnClicked() {
//        var pair = Utils.NumberedButtonClickHelper.Parse(name);
//        System.Reflection.MethodInfo methodInfo = typeof(ClickHandler).GetMethod(pair.Key);
//        methodInfo.Invoke(this, new object[] { pair.Value });
//    }

//    public void BagButton(int index) {
//        switch (SceneManager.GetActiveScene().name) {
//            case "Store":
//                BagButtonInStore(index);
//                break;

//            case "Backpack":
//                BagButtonInBackpack(index);
//                break;
//        }
//    }

//    public void BagButtonInStore(int indexInPackage) {
//        GameObject playerObj = GameObject.FindWithTag("Player");
//        if (playerObj == null) {
//            Debug.Log("Cannot find player");
//            return;
//        }
//        Entity.Player player = playerObj.GetComponent<Entity.Player>();
//        PackageItem item = player.package.Get(indexInPackage);
//        if (item != null) {
//            if (!player.equipment.IsFull()) {
//                player.equipment.Put(item);
//                player.package.Remove(indexInPackage);
//            }
//        }
//        print("In Store");
//    }

//    public void BagButtonInBackpack(int indexInPackage) {
//        GameObject playerObj = GameObject.FindWithTag("Player");
//        if (playerObj == null) {
//            Debug.Log("Cannot find player");
//            return;
//        }
//        Entity.Player player = playerObj.GetComponent<Entity.Player>();
//        PackageItem item = player.package.Get(indexInPackage);
//        if (item != null) {
//            if (!player.equipment.IsFull()) {
//                player.equipment.Put(item);
//                player.package.Remove(indexInPackage);
//            }
//        }
//        print("In Backpack");
//    }

//    public void EquipmentButton(int indexInEquipment) {
//        GameObject playerObj = GameObject.FindWithTag("Player");
//        if (playerObj == null) {
//            Debug.Log("Cannot find player");
//            return;
//        }
//        Entity.Player player = playerObj.GetComponent<Entity.Player>();
//        PackageItem item = player.equipment.Get(indexInEquipment);
//        if (item != null) {
//            if (!player.package.IsFull()) {
//                player.package.Put(item);
//                player.equipment.Remove(indexInEquipment);
//            }
//        }
//        print(indexInEquipment);
//    }

//    public void StoreButton(int indexInStore) {
//        GameObject playerObj = GameObject.FindWithTag("Player");
//        if (playerObj == null) {
//            Debug.Log("Cannot find player");
//            return;
//        }
//        Entity.Player player = playerObj.GetComponent<Entity.Player>();

//        GameObject sellerObject = GameObject.FindWithTag("NPC");
//        if (sellerObject == null) {
//            Debug.Log("Cannot find seller");
//            return;
//        }
//        Entity.TransactionPoint point = sellerObject.GetComponent<Entity.TransactionPoint>();

//        PackageItem item = point.package.Get(indexInStore);
//        if (item != null) {
//            if (!player.package.IsFull()) {
//                player.package.Put(item);
//                point.package.Remove(indexInStore);
//            }
//        }
//        print(indexInStore);
//    }

//}

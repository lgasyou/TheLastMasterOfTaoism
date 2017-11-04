using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Entities;

namespace ClickHandlers {
    public class OnStoreButtonClicked : MonoBehaviour {
        // Use this for initialization
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            var player = Entities.Player.Instance;
            int index = Utils.NumberedButtonClickHelper.Parse(name).Value;
            GameObject sellerObject = GameObject.FindWithTag("NPC");
            if (sellerObject == null) {
                Debug.Log("Cannot find seller");
                return;
            }
            TransactionPoint point = sellerObject.GetComponent<TransactionPoint>();

            PackageItem item = point.package.Get(index);
            if (item != null) {
                if (!player.package.IsFull()) {
                    player.package.Put(item);
                    point.package.Remove(index);
                }
            }
            print("Store" + index);
        }
    }
}

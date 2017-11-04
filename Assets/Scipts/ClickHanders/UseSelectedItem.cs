using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClickHandlers {
    public class UseSelectedItem : MonoBehaviour {
        // Use this for initialization
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            var player = Entities.Player.Instance;
            int index = Utils.NumberedButtonClickHelper.Parse(name).Value;
            PackageItem item = player.package.Get(index);
            if (item != null) {
                if (!player.equipment.IsFull()) {
                    player.equipment.Put(item);
                    player.package.Remove(index);
                }
            }
            print("Item used");
        }
    }
}
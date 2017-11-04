using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ClickHandlers {
    public class OnBagButtonClicked : MonoBehaviour {
        // Use this for initialization
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            string sceneName = SceneManager.GetActiveScene().name;
            var player = Entities.Player.Instance;
            int index = Utils.NumberedButtonClickHelper.Parse(name).Value;
            if (sceneName.Equals("Store")) {
                PackageItem item = player.package.Get(index);
                if (item != null) {
                    if (!player.equipment.IsFull()) {
                        player.equipment.Put(item);
                        player.package.Remove(index);
                    }
                }
                print("In Store");
            } else {
                PackageItem item = player.package.Get(index);
                if (item != null) {
                    if (!player.equipment.IsFull()) {
                        player.equipment.Put(item);
                        player.package.Remove(index);
                    }
                }
                print("In Backpack");
            }
        }
    }
}
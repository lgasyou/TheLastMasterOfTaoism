﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClickHandlers {
    public class OnEquipmentButtonClicked : MonoBehaviour {
        // Use this for initialization
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            var player = Entities.Player.Instance;
            int index = Utils.NumberedButtonClickHelper.Parse(name).Value;
            PackageItem item = player.equipment.Get(index);
            if (item != null) {
                if (!player.package.IsFull()) {
                    player.package.Put(item);
                    player.equipment.Remove(index);
                }
            }
            print("Equipment" + index);
        }
    }
}


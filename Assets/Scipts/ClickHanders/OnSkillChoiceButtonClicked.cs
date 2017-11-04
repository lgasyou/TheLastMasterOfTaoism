﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClickHandlers {
    public class OnSkillChoiceButtonClicked : MonoBehaviour {
        // Use this for initialization
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            int index = Utils.NumberedButtonClickHelper.Parse(name).Value;
            print("Skill" + index);
        }
    }
}

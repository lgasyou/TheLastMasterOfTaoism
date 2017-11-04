using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClickHandler {
    public class OnSkillChoiceButtonClicked : MonoBehaviour {
        // Use this for initialization
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            var p = Utils.NumberedButtonClickHelper.Parse(name);
            int index = p.Value;
            print("Skill" + index);
        }
    }
}

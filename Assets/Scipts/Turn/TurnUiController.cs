using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Turn {
    public class TurnUiController : MonoBehaviour {
        public GameObject skillChoiseObject;
        public GameObject itemChoiseObject;
        public GameObject fightingChoiseObject;

        Dictionary<string, Canvas> canvases = new Dictionary<string, Canvas>();

        // Use this for initialization
        void Start() {
            canvases["Skill"] = skillChoiseObject.GetComponent<Canvas>();
            canvases["Item"] = itemChoiseObject.GetComponent<Canvas>();
            canvases["Main"] = fightingChoiseObject.GetComponent<Canvas>();
            Show("Main");
        }

        void Show(string canvas) {
            foreach (KeyValuePair<string, Canvas> p in canvases) {
                p.Value.enabled = false;
            }
            canvases[canvas].enabled = true;
        }

        public void ShowSkill() {
            Show("Skill");
        }

        public void ShowMain() {
            Show("Main");
        }

        public void ShowItem() {
            Show("Item");
        }

        public void Attack() {
            var turnSystem = GetComponent<TurnSystem>();
            turnSystem.PlayerAttack();
        }
    }
}
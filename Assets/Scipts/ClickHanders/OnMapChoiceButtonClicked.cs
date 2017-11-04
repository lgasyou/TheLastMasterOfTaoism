using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClickHandlers {
    public class OnMapChoiceButtonClicked : MonoBehaviour {
        void Start() {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnClicked);
        }

        public void OnClicked() {
            var player = Entities.Player.Instance;
            string sceneName = name.Split(' ')[0];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            print("On load scene" + sceneName);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagItemClickHandler : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClicked);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClicked() {
        GameObject playerObject = GameObject.FindWithTag("Player");
        Entity.Player player = playerObject.GetComponent<Entity.Player>();

        // Get BagButton (*)
        string right = name.Substring(name.LastIndexOf('(') + 1);
        string meddle = right.Substring(0, right.Length - 1);
        int index = int.Parse(meddle);
        player.package.Get(index);
    }

}

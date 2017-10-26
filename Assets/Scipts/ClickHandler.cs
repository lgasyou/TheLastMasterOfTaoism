using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClicked);
	}

    public void OnClicked() {
        // 'button', '($number)'
        string[] splited = name.Split(' ');
        // $number)
        string withoutLeftParen = splited[1].Substring(1);
        // $number
        string withoutRightParen = withoutLeftParen.Substring(0, withoutLeftParen.Length - 1);
        int index = int.Parse(withoutRightParen);
        System.Reflection.MethodInfo methodInfo = typeof(MoveExecuter).GetMethod(splited[0]);
        methodInfo.Invoke(GetComponent<MoveExecuter>(), new object[] { index });
    }

}

using UnityEngine;
using System.Collections;

// GUIのButtonを表示するスクリプトです。

public class Button : MonoBehaviour {

    bool flg = false;

    // ボタンに設定する画像
    public GUIStyle btnStyle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if(flg == false)
        {
            if(GUI.Button(new Rect (10, Screen.height - 110, 100, 100), "Button", btnStyle))
            {
                flg = true;
            }
        }
    }
}

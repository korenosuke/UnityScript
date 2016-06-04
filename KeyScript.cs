using UnityEngine;
using System.Collections;

//クラス名とファイル名は同じ
public class KeyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//キーの割り当て
		//
		//xxxに割り当てたいキーを与える
		//キーボード変数は下記、URLを参照
		//http://docs.unity3d.com/ja/current/ScriptReference/KeyCode.html
		//
		//if(input.GetKeyDown(keycode.xxx))
		//	実行させる処理

		//Aキーを押した時
		if (Input.GetKeyDown (KeyCode.A))
			Debug.Log ("Aキーが押されました");

		//Aキーを戻した時
		if (Input.GetKeyUp (KeyCode.A))
			Debug.Log ("Aキーが戻りました");
		
	}
}

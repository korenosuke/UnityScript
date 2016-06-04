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
		//キー変数は下記、URLを参照
		//http://docs.unity3d.com/ja/current/ScriptReference/KeyCode.html
		//
		//{xxx}にキー変数を割り当てる
		//KeyCode.{xxx}

		//Aキーを押した時
		if (Input.GetKeyDown (KeyCode.A)){
			Debug.Log ("Aキーが押されました");			
		}

		//Aキーが押されている間
		if(Input.GetKey(KeyCode.A)){
			Debug.Log("Aキーが押されています");
		}

		//Aキーを戻した時
		if (Input.GetKeyUp (KeyCode.A)){
			Debug.Log ("Aキーが戻りました");		
		}
		
	}
}

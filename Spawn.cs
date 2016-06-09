using UnityEngine;
using System.Collections;

// InspectorでgameObjectにゲームオブジェクトをドラッグしてintervalに数値を入力すると
// 指定した秒数ごとにゲームオブジェクトが生成されます。

public class Spawn : MonoBehaviour {

    public GameObject gameObject;
    public float interval;

	// Use this for initialization
	IEnumerator Start () {
        // 無限ループなので注意してください。
        while (true)
        {
            Instantiate(gameObject, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

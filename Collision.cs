using UnityEngine;
using System.Collections;

// あたり判定を追加するメソッドです。
// collider/rigidbodyのComponentを追加してください。
// Inspectorにて"trigger"にチェックを入れると衝突せずに貫通します。
// このとき当たり判定は適用されます。

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // 他のCollider/Rigidbodyに触れたときに呼び出される
    void OnCollisionEnter(Collider other)
    {
        // ここに処理を記述
    }

    // 他のCollider/Rigidbodyに触れ合うのをやめたときに呼び出される
    void OnCollisionExit(Collider other)
    {

    }

    // 他のCollider/Rigidbodyに触れている間毎フレーム毎に呼び出される
    void OnCollisionStay(Collider other)
    {

    }



    // トリガーを設定した時は下記のメソッドも使用できます。

    // Colliderが他のトリガーに侵入したときに呼び出される
    void OnTriggerEnter(Collider other)
    {

    }

    // Colliderが他のトリガーに触れるのをやめたときに呼び出される
    void OnTriggerEixt(Collider other)
    {

    }

    // Colliderが他のトリガーに触れ続けている間ほとんど毎フレームに呼び出される
    void OnTriggerStay(Collider other)
    {

    }

}

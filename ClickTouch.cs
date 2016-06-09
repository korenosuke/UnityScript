using UnityEngine;
using System.Collections;

// クリックしたところの当たり判定を追加するスクリプト

public class ClickTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray;
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            // マウスカーソルの位置からカメラ画面を通してレイを飛ばす
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100)) {
                Debug.Log("Hit");
            }
        }
	
	}
}

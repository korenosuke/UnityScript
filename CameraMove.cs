using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // カメラ移動 左クリック
        if (Input.GetMouseButton(0))
        {
            Camera.main.transform.Translate(Input.GetAxisRaw("Mouse X") / 10,
                Input.GetAxisRaw("Mouse Y") / 10, 0);
        }

        // カメラ回転　右クリック
        if(Input.GetMouseButton(1))
        {
            Camera.main.transform.Rotate(Input.GetAxisRaw("Mouse Y") * 10,
                Input.GetAxisRaw("Mouse X") * 10, 0);
        }
	
	}
}

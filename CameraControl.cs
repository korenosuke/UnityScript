using UnityEngine;
using System.Collections;

// カメラの親オブジェクト(ここでは、CameraParent)を作成し、
// MainCameraを子オブジェクトにする。

public class CameraControl : MonoBehaviour {

    GameObject cameraParent;

    // デフォルト位置保存用
    Vector3 defaultPosition;
    Quaternion defaultRotation;
    float defaultZoom;

    // Use this for initialization
    void Start()
    {
        // 親オブジェクト指定
        cameraParent = GameObject.Find("CameraParent");

        // デフォルト位置を保存
        defaultPosition = Camera.main.transform.position;
        defaultRotation = cameraParent.transform.rotation;
        defaultZoom = Camera.main.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {

        // カメラ移動 左クリック
        if (Input.GetMouseButton(0))
        {
            Camera.main.transform.Translate(Input.GetAxisRaw("Mouse X") / 10,
                Input.GetAxisRaw("Mouse Y") / 10, 0);
        }

        // カメラ回転　右クリック
        if (Input.GetMouseButton(1))
        {
            cameraParent.transform.Rotate(Input.GetAxisRaw("Mouse Y") * 10,
                Input.GetAxisRaw("Mouse X") * 10, 0);
        }

        // ズーム　マウススクロール
        Camera.main.fieldOfView += (20 * Input.GetAxis("Mouse ScrollWheel"));

        // カメラを近づけると上下反転するので、一定以上近づけないようにする。
        if(Camera.main.fieldOfView < 10)
        {
            Camera.main.fieldOfView = 10;
        }

        // カメラ位置をリセット マウススクロールクリック
        if (Input.GetMouseButton(2))
        {
            Camera.main.transform.position = defaultPosition;
            cameraParent.transform.rotation = defaultRotation;
            Camera.main.fieldOfView = defaultZoom;
        }
    }
}

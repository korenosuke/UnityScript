using UnityEngine;
using System.Collections;

// 十字キーで移動できるようになるスクリプトです。
// あらがじめ"Charactor Controller"を追加してください。

public class Move : MonoBehaviour {
    
    // 移動速度調整
    public float moveSpeed = 5f;

    // 振り向き角度調整
    public float rotationSpeed;

    CharacterController characterController;

	// Use this for initialization
	void Start () {

        characterController = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward,
                direction,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
            );
            transform.LookAt(transform.position + forward);
        }
        characterController.Move(direction * moveSpeed * Time.deltaTime);

	}
}

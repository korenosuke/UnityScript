using UnityEngine;
using System.Collections;

public class RandomValue : MonoBehaviour {

    float min = 0;
    float max = 10;

    // 0.0から1.0までの範囲のランダムな値
    //Random.value;

    // minからmaxまでの範囲のランダムな値
    //Random.Range(min, max);


    // Use this for initialization
    void Start () {

        // 例：ランダムな場所にオブジェクトを移動
        transform.position = new Vector3(0, Random.value, Random.Range(min, max));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

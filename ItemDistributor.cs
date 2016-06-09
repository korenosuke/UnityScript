using UnityEngine;
using System.Collections;

// ExTerrainに依存する
public class ItemDistributor : MonoBehaviour {

	[SerializeField, TooltipAttribute("設置したいアイテムのPrefab")]
		private GameObject item;

	[SerializeField, TooltipAttribute("設置範囲のX座標最大値")]
		private float X_MAX = 120;

	[SerializeField, TooltipAttribute("設置範囲のX座標最小値")]
		private float X_MIN = 0;

	[SerializeField, TooltipAttribute("設置範囲のY座標最大値")]
		private float Z_MAX = 120;

	[SerializeField, TooltipAttribute("設置範囲のX座標最小値")]
		private float Z_MIN = 0;

	[SerializeField, TooltipAttribute("設置したいアイテムの個数")]
		private int ITEM_QUANTITY = 120;

	[SerializeField, TooltipAttribute("設置したいアイテムの地面からの高さ")]
		private float ITEM_HEIGHT = 0.5f;

	// Use this for initialization
	void Start () {	}
	
	// Update is called once per frame
	void Update () { }

	// 指定したパラメータを基にランダムにオブジェクトを配置
	public void DistributeItems() {
		for(int i = 0; i < ITEM_QUANTITY; i++ ) {
			float x = Random.Range(X_MIN, X_MAX);
			float z = Random.Range(Z_MIN, Z_MAX);
			float y = Terrain.activeTerrain.GetHeight(x, z);
			Instantiate(item, new Vector3(x, y+ITEM_HEIGHT, z), Quaternion.identity);
		}
	}

}

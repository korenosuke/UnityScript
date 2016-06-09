using UnityEngine;

// 使い方 : Assets以下の適当なところに放り込むだけ
static class ExTerrain {

	// Terrainオブジェクト上での指定座標の高度を取得
	// ex. Terrain.activeTerrain.GetHeight(20.0f, 31.5f)
	public static float GetHeight(this Terrain terrain, float x, float z) {
		return terrain.terrainData.GetInterpolatedHeight(
						x/terrain.terrainData.size.x,
						z/terrain.terrainData.size.z);
					}

}

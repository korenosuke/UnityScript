using UnityEngine;
using System.Collections;

/*
    1.ステージのゲームオブジェクトを選択して、InspectorからNavigationStaticを選択
    2.メニューのWindowからNavigationを選択し、Navigationビューを表示
    3.BakeをクリックしてNavMeshを作成
    4.NavMeshAgentコンポーネントを追加
*/

// targetで指定したオブジェクトを自動的に追いかけるスクリプト

public class Navigation : MonoBehaviour {

    public GameObject target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {

        agent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {

        agent.destination = target.transform.position;
	
	}
}

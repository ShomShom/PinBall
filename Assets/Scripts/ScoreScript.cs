using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	//スコアを表示するテキスト
	private GameObject ScoreText;
	int num = 0;

	// Use this for initialization
	void Start () {
		//シーン中のScoreオブジェクトを取得
		this.ScoreText = GameObject.Find("Score");

	}
	
	// Update is called once per frame
	void Update () {

		//Scoreに点数を表示
		this.ScoreText.GetComponent<Text> ().text = "Score " + num;
	
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {

		// タグによって点数を変える
		if (other.gameObject.tag == "SmallStarTag") {
			this.num += 1;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.num += 10;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			this.num += 20;
		}else if(other.gameObject.tag == "LargeCloudTag") {
			this.num += 100;
		}

	}
}
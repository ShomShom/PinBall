using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//大きな星をゲーム開始時からゲーム終了まで回転させるスクリプト

public class StarController : MonoBehaviour {

	//回転速度
	private float rotSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		//回転を開始する角度を設定
		this.transform.Rotate (0, Random.Range (0, 360), 0);
	}
	
	// Update is called once per frame
	void Update () {
		//回転
		//X軸、Y軸、Z軸を中心とした回転量を渡す。
		this.transform.Rotate (0, this.rotSpeed, 0);
	}
}

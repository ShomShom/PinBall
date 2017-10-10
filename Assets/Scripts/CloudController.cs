using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	//最小サイズ
	private float minimum = 1.0f;
	//拡大縮小スピード
	private float magSpeed = 10.0f;
	//拡大率
	private float magnification = 0.07f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//雲を拡大縮小
		//オブジェクトのサイズを変更
		//「Vector」は、オブジェクトの座標やオブジェクトに加わる力の方向などを扱う型
		//Vector2はfloat型のx, yの要素を持つ
		//Vector3はfloat型のx, y, zの要素を持つ
		this.transform.localScale
		=  new Vector3(this.minimum +  Mathf.Sin(Time.time * this.magSpeed) * this.magnification,
			this.transform.localScale.y,//yは高さなので大小する必要がない。
			this.minimum +  Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
	}
}

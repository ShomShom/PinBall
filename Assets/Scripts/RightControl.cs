using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControl : MonoBehaviour {

	//HingiJointコンポーネントを入れる
	private HingeJoint myHingeJoint;

	//初期の傾き
	private float defaultAngle = 20;
	//弾いた時の傾き
	private float flickAngle = -20;

	// Use this for initialization
	void Start () {
		//HinjiJointコンポーネント取得
		this.myHingeJoint = GetComponent<HingeJoint>();

		//フリッパーの傾きを設定
		SetAngle(this.defaultAngle);
	}

	void Update () {
		if (Input.touchCount > 0) {
			foreach (Touch t in Input.touches) {
				if (t.phase == TouchPhase.Began){
					if (t.position.x > Screen.width/2) {
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit hit;


						if (Physics.Raycast (ray, out hit)) {
							GameObject selectedObj = hit.collider.gameObject;               
							SetAngle (this.flickAngle);
						}
					}
				}

				if (t.phase == TouchPhase.Ended || t.phase == TouchPhase.Canceled) {
					if (t.position.x > Screen.width/2) {
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit hit;


						if (Physics.Raycast (ray, out hit)) {
							GameObject selectedObj = hit.collider.gameObject;               
							SetAngle (this.defaultAngle);
						}
					}
				}
			}
		}

		if(Input.touchCount == 0){
			SetAngle (this.defaultAngle);
		}
	}

	//フリッパーの傾きを設定
	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}

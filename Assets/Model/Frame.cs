using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Frame {
	
	public string frameCode; // フレームの識別子
	public string frameName; // フレームの名前
	public string image;     // フレームのイメージ
	public int hp;           // ロボットのヒットポイント
	public int speed;        // ロボットのワンアクションの実行スピード
	public int defence;      // ロボットの防御力
	public int attack;       // ロボットの攻撃力
}

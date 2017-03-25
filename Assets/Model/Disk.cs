using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Disk  {

	public string diskCode;       // Diskコード
	public string diskName;       // Diskの名前
	public int capacity;          // ディスクの容量

	public double attackModify;   // ロボット攻撃力修正値
	public double sppedModify;    // ロボット実行スピード修正値
	public double defenceModify;  // ロボット防御力修正値
	public double hpModify;       // ロボットヒットポイント修正値

}

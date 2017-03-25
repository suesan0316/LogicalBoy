using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CPU {

	public string cpuCode;       // CPUコード
	public int core;             // コア数
	public int slot;             // モジュールのスロット数
	public string cpuName;       // CPUの名前

	public double attackModify;  // ロボット攻撃力修正値
	public double speedModify;   // ロボット実行スピード修正値
	public double defenceModify; // ロボット防御力修正値
	public double hpModify;      // ロボットヒットポイント修正値
}

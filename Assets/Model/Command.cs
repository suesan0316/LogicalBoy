using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command {

	public string commandCode;  // Commandコード
	public int needMemory;      // 必要メモリー容量
	public int needDisk;        // 必要ディスク容量
	public string commandName;  // Commnadの名前
	public string delegateName; // Commandの実行メソッド
}

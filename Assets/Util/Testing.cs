using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CPU cpu = new CPU ();
		cpu.core = 1;
		cpu.attackModify = 1.0;
		cpu.cpuCode = "NormalCPU1";
		cpu.defenceModify = 1.0;
		cpu.hpModify = 1.0;
		cpu.slot = 2;

		string json = JsonUtility.ToJson(cpu);

		CPU cpu1 = new CPU ();
		cpu1.core = 1;
		cpu1.attackModify = 1.0;
		cpu1.cpuCode = "NormalCPU2";
		cpu1.defenceModify = 1.0;
		cpu1.hpModify = 1.0;
		cpu1.slot = 2;

		List<CPU> cpus = new List<CPU> ();

		cpus.Add (cpu);
		cpus.Add (cpu1);

		string json2 = JsonUtility.ToJson(cpus);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

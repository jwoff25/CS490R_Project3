using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject {
	public class KillCountManager : MonoBehaviour {

		Text t;
		public static int kills;

		// Use this for initialization
		void Start () {
			t = GetComponent<Text> ();
			kills = 0;
		}
		
		// Update is called once per frame
		void Update () {
			t.text = "Kills: " + kills.ToString();
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject 
{
	public class EnemyCountManager : MonoBehaviour {

		Text t;
		public static int count;

		// Use this for initialization
		void Start () {
			count = 0;
			t = GetComponent<Text> ();
		}
		
		// Update is called once per frame
		void Update () {
			t.text = "Enemies: " + count.ToString();
		}
	}
}
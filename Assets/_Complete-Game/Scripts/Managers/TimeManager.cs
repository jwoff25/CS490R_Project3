using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
	public class TimeManager : MonoBehaviour {

		public float timer;
		Text t;

		// Use this for initialization
		void Start () {
			timer = 0;
			t = GetComponent<Text> ();
		}
		
		// Update is called once per frame
		void Update () {
			timer += Time.deltaTime % 60;
			if (timer < 99.99) {
				t.text = "Time: " + timer.ToString ("00.00");
			} else {
				t.text = "Time: " + timer.ToString ("000.00");
			}
		} 
	}
}

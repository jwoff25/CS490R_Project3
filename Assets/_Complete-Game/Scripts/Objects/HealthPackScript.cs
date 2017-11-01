using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject {
	public class HealthPackScript : MonoBehaviour {

		public int healAmount = 10;

		void OnTriggerEnter(Collider other){
			PlayerHealth ph = other.GetComponent<PlayerHealth> ();
			print (ph.currentHealth);
			if (ph.currentHealth <= 90) {
				ph.currentHealth += healAmount;
				ph.healthSlider.value = ph.currentHealth;
			} else if (ph.currentHealth > 90 && ph.currentHealth < 100) {
				ph.currentHealth = 100;
				ph.healthSlider.value = ph.currentHealth;
			} 
			gameObject.SetActive (false);
		}
	}
}
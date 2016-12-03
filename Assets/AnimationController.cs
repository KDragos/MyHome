using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	public GameObject globe;
	public GameObject tvScreen;
	public GameObject faucet;
	public GameObject computerScreen;

	private Animator animator; 
	private bool spinning = false; 

	void Start ()
	{
		animator = globe.GetComponent<Animator>();
	}

	public void SpinGlobe ()
	{
		if (spinning) {
			spinning = false; // Stop spinning.
			animator.SetBool("Spin", spinning);
		} else {
			spinning = true; // Start spinning.
			animator.SetBool("Spin", spinning);
		}

	}

	public void TriggerTV() {
		tvScreen.gameObject.SetActive(!tvScreen.gameObject.activeInHierarchy);
	}

	public void TriggerFaucet () {
		faucet.gameObject.GetComponentInChildren<ParticleSystem>().Play();
	}

	public void TriggerComputer() {
		computerScreen.gameObject.SetActive(!computerScreen.gameObject.activeInHierarchy);
	}
}

using UnityEngine;
using System.Collections;

public class Flag : MonoBehaviour {

	bool active;

	// Use this for initialization
	void Start () {
		active = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && this.active)
		{
			other.GetComponent<Player>().has_flag = true;
			gameObject.SetActive(false);
		}
	}
}

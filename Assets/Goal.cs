using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public bool team;  //True for blue, false for red
	GameObject flag;

	// Use this for initialization
	void Start () {
        flag = GameObject.FindGameObjectWithTag("Flag");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			if (other.GetComponent<Player>().has_flag)
			{
				other.GetComponent<Player>().has_flag = false;
				flag.SetActive(true);
			}
		}
	}
}

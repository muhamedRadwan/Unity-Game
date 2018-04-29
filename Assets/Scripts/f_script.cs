using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class f_script : MonoBehaviour {

	public GameObject cube;
	public GameObject player;


	void Start () {
		cube = GameObject.Find("TheEndPanel");
		player = GameObject.Find("Player");

	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("panel");
	}
}

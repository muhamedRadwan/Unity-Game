using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour {
	[SerializeField] private Transform player;
	[SerializeField] private Transform respwanPoint;

	void OnTriggerEnter(Collider other){

		player.transform.position = respwanPoint.transform.position;
}
}

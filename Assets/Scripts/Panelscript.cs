using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Panelscript : MonoBehaviour {

	public GameObject Panel;
	public Button plus;
	public Button eleven;
	public Button equal;
	public Button five;
	public Button six;
	public Button ok;
	public Text written;
	public string solve = "5+6=11";
	public string solve1 = "6+5=11";
	void Start()
	{
		Button btn1 = plus.GetComponent<Button>();
		btn1.onClick.AddListener(()=>this.TaskOnClick(plus.GetComponentInChildren<Text>().text));

		Button btn2 = five.GetComponent<Button>();
		btn2.onClick.AddListener(() => this.TaskOnClick(five.GetComponentInChildren<Text>().text));

		Button btn3 = six.GetComponent<Button>();
		btn3.onClick.AddListener(() => this.TaskOnClick(six.GetComponentInChildren<Text>().text));

		Button btn4 = equal.GetComponent<Button>();
		btn4.onClick.AddListener(() => this.TaskOnClick(equal.GetComponentInChildren<Text>().text));

		Button btn5 = ok.GetComponent<Button>();
		btn5.onClick.AddListener(() => this.TaskOnClick(ok.GetComponentInChildren<Text>().text));

		Button btn6 = eleven.GetComponent<Button>();
		btn6.onClick.AddListener(() => this.TaskOnClick(eleven.GetComponentInChildren<Text>().text));

		written = written.GetComponent<Text>();

	}

	

	public void TaskOnClick(string s)
	{
		if(s != "OK")
			written.GetComponent<Text>().text += s;
		else
		{
			if (solve == written.GetComponent<Text>().text || solve1 == written.GetComponent<Text>().text)
			{
				Debug.Log("Sucess");
				SceneManager.LoadScene("forest");
				Panel.SetActive(false);

			}
			else
			{
				Debug.Log("Try again");
				written.GetComponent<Text>().text = "";


			}
		}
	}

}

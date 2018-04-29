using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelSnowScript : MonoBehaviour {

	public GameObject PanelSnow;
	public Button fourtysix;
	public Button sixteen;
	public Button comma;
	public Button hundred;
	public Button thirtytwo;
	public Button ok;
	public Text written;
	public string solve = "16,32,64,128";

	void Start()
	{
		Button btn1 = fourtysix.GetComponent<Button>();
		btn1.onClick.AddListener(()=>this.TaskOnClick(fourtysix.GetComponentInChildren<Text>().text));

		Button btn2 = sixteen.GetComponent<Button>();
		btn2.onClick.AddListener(() => this.TaskOnClick(sixteen.GetComponentInChildren<Text>().text));

		Button btn3 = comma.GetComponent<Button>();
		btn3.onClick.AddListener(() => this.TaskOnClick(comma.GetComponentInChildren<Text>().text));

		Button btn4 = hundred.GetComponent<Button>();
		btn4.onClick.AddListener(() => this.TaskOnClick(hundred.GetComponentInChildren<Text>().text));

		Button btn5 = ok.GetComponent<Button>();
		btn5.onClick.AddListener(() => this.TaskOnClick(ok.GetComponentInChildren<Text>().text));

		Button btn6 = thirtytwo.GetComponent<Button>();
		btn6.onClick.AddListener(() => this.TaskOnClick(thirtytwo.GetComponentInChildren<Text>().text));

		written = written.GetComponent<Text>();

	}



	public void TaskOnClick(string s)
	{
		if(s != "OK")
			written.GetComponent<Text>().text += s;
		else
		{
			if (solve == written.GetComponent<Text>().text )
			{
				Debug.Log("Sucess");
				SceneManager.LoadScene("forest");
				PanelSnow.SetActive(false);

			}
			else
			{
				Debug.Log("Try again");
				written.GetComponent<Text>().text = "";


			}
		}
	}

}

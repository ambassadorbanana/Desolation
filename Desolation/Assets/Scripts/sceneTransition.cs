using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour {
	public bool fadeOutOnStart;
	public float fadeOutOnStartDelay = 2f;
	public float fadeSpeed = 1f;
	public Color filledColor = Color.black;
	public Color transparentColor = Color.clear;

	public Text titleText;
	public float title_fadeSpeed = 2f;
	public Color title_filledColor = Color.white;
	public Color title_transparentColor = Color.clear;
	private Image img;
	private bool isFadingIn;
	private string newScene;
	private float waitThreashold;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
		isFadingIn = false;
		if (fadeOutOnStart) {
			img.color = filledColor;
			titleText.color = title_filledColor;
			gameObject.SetActive (true);
			titleText.gameObject.SetActive (true);
		} else {
			img.color = transparentColor;
			titleText.color = title_transparentColor;
			gameObject.SetActive (false);
			titleText.gameObject.SetActive (false);
		}
		waitThreashold = Time.time + fadeOutOnStartDelay;
	}
	
	// Update is called once per frame
	void Update () {
		if (!fadeOutOnStart || (Time.time > waitThreashold)) {
			if (isFadingIn) {
				img.color = Color.Lerp (img.color, filledColor, Time.deltaTime * fadeSpeed);
				if (Mathf.Abs (img.color.a - filledColor.a) < 0.1) {
					SceneManager.LoadScene (newScene);
				}
			} else {
				img.color = Color.Lerp (img.color, transparentColor, Time.deltaTime * fadeSpeed);
				titleText.color = Color.Lerp (titleText.color, title_transparentColor, Time.deltaTime * title_fadeSpeed);
				if (img.color.a < 0.05f) {
					gameObject.SetActive (false);
				}
				if (titleText.color.a < 0.05f) {
					titleText.gameObject.SetActive (false);
				}
			}
		}
	}

	public void setTransition(string scene){
		newScene = scene;
		isFadingIn = true;
		gameObject.SetActive (true);
	}
}

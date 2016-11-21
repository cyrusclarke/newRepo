using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mCtrl : MonoBehaviour {

	public MediaPlayerCtrl mCtrl1;

//Load some file to the MediaPlayer Controller for the GameObject and play
	private void Awake () {
		Debug.Log ("alive");
		mCtrl1.Load ("IXDAParody.mp4");
		mCtrl1.Play();

	}

	void Update () {
		HandleTimeInput ();

	}

	 public void HandleTimeInput () {
		///Basic Controls for Playback
		if (Input.GetKeyDown ("p")){
			mCtrl1.Pause ();
	}
		if(Input.GetKeyDown ("s")){
			mCtrl1.Play();
		}
    //Check Gaze (not working)
		Debug.Log("IM GAZING"); 
	
	}
}

using UnityEngine;
using System.Collections;

public class CameraSound : MonoBehaviour {

    [SerializeField] private AudioSource adSource;

	// Use this for initialization
	void Awake () {
        if (!ButBehave.BgMusicState)
        {
            adSource.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

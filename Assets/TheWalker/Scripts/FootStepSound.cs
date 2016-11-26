using UnityEngine;
using System.Collections;

public class FootStepSound : MonoBehaviour {
    [SerializeField]
    private AudioSource adSource;

    // Use this for initialization
    void Awake()
    {
        if (!ButBehave.InGameMusicState)
        {
            adSource.enabled = false;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}

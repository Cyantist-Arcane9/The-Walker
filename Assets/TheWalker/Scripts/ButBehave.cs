using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButBehave : MonoBehaviour {
    public static bool BgMusicState = true;
    public static bool InGameMusicState = true;
    public static bool LoadIt = false;
    Image myImageComponent;
    [SerializeField]
    private GameObject frontUI;
    [SerializeField]
    private AudioSource adSource;
    [SerializeField]
    private Sprite bgMOff;
    [SerializeField]
    private Sprite bgMOn;
    [SerializeField]
    private Sprite inMOff;
    [SerializeField]
    private Sprite inMOn;

    // Use this for initialization
    void Start () {
        myImageComponent = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayGame()
    {
        frontUI.SetActive(false);
        LoadIt = true;
    }

    public void BgMusicToggle()
    {
        if (BgMusicState)
        {
            myImageComponent.sprite = bgMOff;    
            BgMusicState = false;
            adSource.Stop();
        }
        else
        {
            myImageComponent.sprite = bgMOn;
            BgMusicState = true;
            adSource.Play();
        }
    }

    public void InGameMusicToggle()
    {
        if (InGameMusicState)
        {
            myImageComponent.sprite = inMOff;
            InGameMusicState = false;
        }
        else
        {
            myImageComponent.sprite = inMOn;
            InGameMusicState = true;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

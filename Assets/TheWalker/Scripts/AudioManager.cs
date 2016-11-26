using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    [SerializeField] AudioClip[] m_audioClips;

    Animator anim;
    
    AudioSource m_audioSource;
    
    // Use this for initialization
    void Start ()
    {
        m_audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void PlayFootStep()
    {
        m_audioSource.clip = m_audioClips[Random.Range(0, 1)];
        m_audioSource.Play();
    }

    void PlayRunStep()
    {
        m_audioSource.clip = m_audioClips[Random.Range(2, 3)];
        m_audioSource.Play();
    }

    void PlayJump ()
    {
        m_audioSource.clip = m_audioClips[4];
        m_audioSource.Play();

    }
    void PlayCrouch()
    {
        m_audioSource.clip = m_audioClips[5];
        m_audioSource.Play();


        if (anim.GetFloat("Forward")!=0 || anim.GetFloat("Turn") != 0)
        {
            m_audioSource.clip = m_audioClips[Random.Range(0,1)];
            m_audioSource.Play();
        }
    }
}

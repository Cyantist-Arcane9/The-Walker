using UnityEngine;
using System.Collections;

public class LoadMenu : MonoBehaviour {

    public GameObject menuUI;

    private GameObject m_Go;

    void Awake()
    {
        if (m_Go == null)
        {
            m_Go = Instantiate(menuUI);
        }
    }
}

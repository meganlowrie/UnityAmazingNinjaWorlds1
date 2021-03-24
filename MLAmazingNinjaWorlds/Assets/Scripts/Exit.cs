using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    SpriteRenderer m_renderer;
    public GameObject gem;
    public GameObject background;
    public string teleportDestination;

    private void Start()
    {
        m_renderer = gem.GetComponent<SpriteRenderer>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(m_renderer.enabled == false)
        {
            background.GetComponent<GameManager>().TeleportOpen(teleportDestination);
        }

    }
}

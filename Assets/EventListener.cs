using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    private Renderer renderers;
    [SerializeField] GameObject player;
    [SerializeField] GameObject destiny;
    // Start is called before the first frame update
    void Start()
    {
        renderers = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        renderers.material.color = Color.red;
        player.transform.position = destiny.transform.position;
    }
    public void OnEnxit()
    {
        renderers.material.color = Color.white;
    }
}

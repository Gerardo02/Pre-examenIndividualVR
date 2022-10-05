using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    static int puntos;
    
    [SerializeField] GameObject puntaje;
    [SerializeField] AudioSource audioSource { get { return GetComponent<AudioSource>(); }}
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter(GameObject moneda)
    {
        Debug.Log(puntos);
        Destroy(moneda);
        puntos += 1;
        puntaje.GetComponent<Text>().text = puntos.ToString();
        
        audioSource.PlayOneShot(clip);
        
    }
    
    
    
}

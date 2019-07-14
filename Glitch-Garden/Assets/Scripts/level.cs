using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    [SerializeField] AudioClip soundScreen;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(soundScreen, Camera.main.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

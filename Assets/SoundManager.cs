using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource a1;
    [SerializeField] private AudioSource a2;
    [SerializeField] private AudioClip c1;
    [SerializeField] private AudioClip c2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SE_ya()
    {
        a1.PlayOneShot(c1);
    }

    public void SE_achaa()
    {
        a2.PlayOneShot(c2);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public AudioSource suara;


    public void mulai()
    {
        suara.Play();
    }

    public void stopsuara()
    {
        suara.Stop();
    }
}

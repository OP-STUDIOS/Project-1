﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public void PlayBulletImpactSound()
    {
        GetComponent<AudioSource>().Play();
    }
}

﻿using UnityEngine;
using System.Collections;

public class Sizzle : MonoBehaviour {

    public AudioClip sizzleStart;
    public AudioClip sizzleLoop;

    private bool started;

    [SerializeField]
    private AudioSource audio;

    private float lowrange = .75F;
    private float highrange = 1F;

    [SerializeField]
    private CookingFoods cookingscript;

    void Update()
    {
        if (InteractableItem.iscooking )//cookingscript.IsCooking == true)
        {
            audio.pitch = Random.Range(lowrange, highrange);
            audio.loop = true;
            if (started == false)
            {
                started = true;
                audio.PlayOneShot(sizzleStart, 1F);
            }

            audio.clip = sizzleLoop;
            audio.PlayOneShot(sizzleLoop, .2F);


        }
        else
        {
            audio.clip = sizzleLoop;
            audio.loop = false;
            started = false;
            audio.Stop();
        }

    }

}

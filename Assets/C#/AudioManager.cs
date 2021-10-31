using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    static AudioManager current;
    public AudioClip monsterDie, monsterPain, playerHurt;
    AudioSource enemyDie, enemyPain, playergetgurt;

    private void Awake()
    {
        current = this;
        DontDestroyOnLoad(gameObject);
        enemyDie = gameObject.GetComponent<AudioSource>();
        enemyPain = gameObject.GetComponent<AudioSource>();
        playergetgurt = gameObject.GetComponent<AudioSource>();
    }

}

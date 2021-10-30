using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instance;
    public AudioSource audioSource;
    [SerializeField]
    private AudioClip Monsterdie, monsterPain, playerhurt;

    private void Awake()
    {
        instance = this;
    }

    public void MonsterDie()
    {
        audioSource.clip = Monsterdie;
        audioSource.Play();
    }
}

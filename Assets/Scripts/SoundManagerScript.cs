using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip fireSound, targetHitSound;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        fireSound = Resources.Load<AudioClip>("Fire");
        targetHitSound = Resources.Load<AudioClip>("Hit");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Fire":
                audioSrc.PlayOneShot(fireSound);
                break;
            case "Hit":
                audioSrc.PlayOneShot(targetHitSound);
                break;
        }
    }
}

using UnityEngine;

public class SoundManager : MonoBehaviour
{
   [SerializeField]
    private AudioSource audioSourceSound;

    [SerializeField]
    private AudioClip collectibleSound;

public static SoundManager Instance;

private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayCollectibleSound()
    {
        audioSourceSound.PlayOneShot(collectibleSound);
    }
}

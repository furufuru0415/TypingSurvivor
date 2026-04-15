using UnityEngine;

public class SESoundVolume : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // AudioManagerから音量を取得して反映
        audioSource.volume = AudioManager.Instance.GetSEVolume();
    }

    void Update()
    {
    audioSource.volume = AudioManager.Instance.GetSEVolume();
    }
}

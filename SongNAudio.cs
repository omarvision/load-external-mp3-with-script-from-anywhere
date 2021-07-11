using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SongNAudio : MonoBehaviour
{
    public string path = "c:/omar/song.mp3";
    private AudioSource aud = null;

    private void Start()
    {
        aud = this.GetComponent<AudioSource>();
        StartCoroutine(LoadSongCoroutine());
    }
    private IEnumerator LoadSongCoroutine()
    {
        string url = string.Format("file://{0}", path);
        WWW www = new WWW(url);
        yield return www;

        aud.clip = NAudioPlayer.FromMp3Data(www.bytes);
        aud.Play();
    }
}

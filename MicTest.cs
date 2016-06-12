using UnityEngine;
using System.Collections;

public class MicTest : MonoBehaviour
{
    private new AudioSource audio;
    private float vol;
    private float x = 0;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = Microphone.Start(null, true, 999, 44100);  // マイクからのAudio-InをAudioSourceに流す
        audio.loop = true;                                      // ループ再生にしておく
        //audio.mute = true;                                    // マイクからの入力音なので音を流す必要がない
        while (!(Microphone.GetPosition("") > 0)) { }           // マイクが取れるまで待つ。空文字でデフォルトのマイクを探してくれる
        audio.Play();                                           // 再生する
    }

    void Update()
    {
        vol = GetAveragedVolume() * 0.01f;
        Debug.Log(vol);
        this.transform.position += new Vector3(x+=vol, 0, 0);
    }

    public float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        audio.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 256.0f;
    }
}
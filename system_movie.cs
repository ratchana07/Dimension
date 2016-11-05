using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class system_movie : MonoBehaviour {

    public MovieTexture cutplay;
    private AudioSource sound;
    public string title = "scence";
    public float deltime = 5.0f;


    // Use this for initialization
    void Start () {
        GetComponent<RawImage>().texture = cutplay as MovieTexture;
        sound = GetComponent<AudioSource>();
        sound.clip = cutplay.audioClip;
        sound.Play();
        cutplay.Play();
        Invoke("DestroyAfterSoundend", deltime); //if time 3.5 second  chang scene

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && cutplay.isPlaying) {
            cutplay.Pause();

        } else if (Input.GetKeyDown(KeyCode.Space) && !cutplay.isPlaying) {
            cutplay.Play();

        }
    }

    void DestroyAfterSoundend()// stop time go to scence
    {

        Application.LoadLevel(title);

    }

}

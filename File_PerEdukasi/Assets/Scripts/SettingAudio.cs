using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingAudio : MonoBehaviour {

	// Reference to Audio Source component
    private AudioSource audioSrc;

    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume = 1f;

	// Use this for initialization
	void Start () {

        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = musicVolume;
	}

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    /*private static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    public void LoadScene()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("Kat_Game", LoadSceneMode.Single);
        }
    }*/

    /*private static SettingAudio instance = null;
    public static SettingAudio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }*/
}

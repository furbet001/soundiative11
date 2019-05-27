using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class gameManager : MonoBehaviour
{
    public List<GameObject> videoList = null;
    public List<GameObject> audioList = new List<GameObject>();



    int randomSound;



    void Start()
    {

        randomSound = Random.Range(0, 4);
        // the below script, places the audio into the scene instead of a prefab. 
        GameObject newSound = Instantiate(audioList[randomSound]);
        newSound.GetComponent<AudioSource>().Play();

        Debug.Log(randomSound);

    }


}

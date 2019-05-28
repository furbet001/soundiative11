using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tissue : MonoBehaviour
{
    public GameObject cameraM;
    public int index;

    public void ButtonPress(string index)
    {
        if (cameraM.GetComponent<gameManager>().randomSound == int.Parse(index))
        {
       
            Debug.Log("correct");
        }
        else
        {
            Debug.Log("Incorrect");
        }


    }
}

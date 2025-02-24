using System;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionEnter : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1.0f;
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Finish":
                StartFinishSequence();
                break;
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Fuel":
                Debug.Log("Fuel");
                break;
            default:
                StartCrashSequence();
                break;
        }
    }

    private void StartFinishSequence()
    {
        Invoke("LoadNextLevel", levelLoadDelay);
        Debug.Log("Selamat Anda Menang!");
    }

    private void StartCrashSequence()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }

    void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.sceneCountInBuildSettings-1 != currentScene)
        {
            SceneManager.LoadScene(currentScene+1);
        }
        else
        {
            Debug.Log("Anda Menang");
        }
    }

    void ReloadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}

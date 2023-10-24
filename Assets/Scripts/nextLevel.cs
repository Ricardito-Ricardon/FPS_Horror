using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    [SerializeField] int levelNumber;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameplayStatics.GetPlayerGameObject())
        {
            PlayerPrefs.SetInt("level", levelNumber);
            PlayerPrefs.Save();
            SceneManagerHelper.ReloadScene();
        }
    }
}
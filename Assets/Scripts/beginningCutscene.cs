using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginningCutscene : MonoBehaviour
{
    [SerializeField] GameObject cutsceneCam, player;
    [SerializeField] float cutsceneTime;

    void Start()
    {
        StartCoroutine(cutscene());
    }
    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(cutsceneTime);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
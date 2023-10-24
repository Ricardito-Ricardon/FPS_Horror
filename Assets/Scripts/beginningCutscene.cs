using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginningCutscene : MonoBehaviour
{
    [SerializeField] GameObject cutsceneCam, player;
    float cutsceneTime;

    void Start()
    {

        Animator animator = cutsceneCam.GetComponent<Animator>();
        cutsceneTime = animator.GetCurrentAnimatorStateInfo(0).length;
        StartCoroutine(cutscene());
    }
    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(cutsceneTime);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
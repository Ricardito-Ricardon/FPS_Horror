using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obungaJumpscare : MonoBehaviour
{
    [SerializeField] Animator obungaAnim;
    float jumpscareTime;
    [SerializeField] AudioSource scareSound;
    [SerializeField] AudioSource scaryMusic;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            obungaAnim.SetTrigger("jumpscare");
            jumpscareTime = obungaAnim.runtimeAnimatorController.animationClips[0].length;
            StartCoroutine(jumpscare());
            scaryMusic.Stop();
            scareSound.Play();
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManagerHelper.ReloadScene();
    }
}
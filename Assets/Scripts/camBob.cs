using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBob : MonoBehaviour
{
    [SerializeField] Animator cameraAnim;

    void Update()
    {
        if (IsWalking())
        {
            cameraAnim.ResetTrigger("idle");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("walk");

            if (Input.GetKey(KeyCode.LeftShift))
            {
                cameraAnim.ResetTrigger("walk");
                cameraAnim.ResetTrigger("idle");
                cameraAnim.SetTrigger("sprint");
            }
        }
        else
        {
            cameraAnim.ResetTrigger("walk");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("idle");
        }
    }

    bool IsWalking()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
    }
}
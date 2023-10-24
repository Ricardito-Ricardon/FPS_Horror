using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameplayStatics 
{
    static GameObject playerGameObject;

    public static GameObject GetPlayerGameObject()
    {
        if(playerGameObject == null)
        {
            playerGameObject = GameObject.FindGameObjectWithTag("Player");
        }

        return playerGameObject;
    }
}

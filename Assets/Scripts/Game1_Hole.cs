using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1_Hole : MonoBehaviour
{
    public GameObject theManager;

    public void plugHole()
    {
        theManager.GetComponent<Game1>().holeCount--;
        this.gameObject.SetActive(false);
    }
}

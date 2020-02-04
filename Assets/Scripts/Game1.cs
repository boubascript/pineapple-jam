using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game1 : MonoBehaviour
{
    public GameObject pineapple;
    Sprite pineapple_Image;
    public GameObject[] pineapple_holes;

    public GameObject ObjectiveScreen;
    public bool Pass_Fail;

    bool blankRoutine = true;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("waitingStart", 2);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("waitingStart", 2);
    }

    //================================================
    //                  Coroutines
    //================================================

    IEnumerator waitingStart(float sec)
    {
        if (blankRoutine == true)
        {
            blankRoutine = false;
            yield return new WaitForSeconds(sec);
            ObjectiveScreen.SetActive(false);
        }
    }
}

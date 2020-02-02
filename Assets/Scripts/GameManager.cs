using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject   game1, 
                        blankScreen;

    public Text ready;

    bool blankRoutine = true;

    public enum MicroGames
    {
        START,
        GAME,
        INBETWEEN,
        END
    }; MicroGames microgames;

    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        game1.SetActive(false);
        blankScreen.SetActive(false);

        microgames = MicroGames.START;
    }

    // Update is called once per frame
    void Update()
    {
        switch (microgames)
        {
            case MicroGames.START:
                blankScreen.SetActive(true);
                StartCoroutine("waitingStart",2);
                break;

            case MicroGames.GAME:
                blankScreen.SetActive(false);
                game1.SetActive(true);
                break;

            case MicroGames.INBETWEEN:
                break;

            case MicroGames.END:
                break;
        }
    }

    //===========================================================
    //              Coroutines
    //===========================================================

    IEnumerator waitingStart(float sec)
    {
        if (blankRoutine == true)
        {
            blankRoutine = false;
            yield return new WaitForSeconds(sec);
            microgames = MicroGames.GAME;
        }
    }


}

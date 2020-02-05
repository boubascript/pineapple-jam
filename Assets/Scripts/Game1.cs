using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game1 : MonoBehaviour
{
    public GameObject       pineapple_sad, 
                            pineapple_happy;

    public GameObject[]     pineapple_holes;
    GameObject              currentHole;
    public int              startHoles;
    public int              holeCount = 0;

    public GameObject       ObjectiveScreen;
    public bool             Pass = false,
                            Fail = false;

    public float            time;
    float                   timer = 0;
    bool                    startTimer = false;

    bool                    blankRoutine = true;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startHoles;)
        {
            currentHole = pineapple_holes[Random.RandomRange(0, pineapple_holes.Length)];
            if (currentHole.activeInHierarchy == false)
            {
                currentHole.SetActive(true);
                i++;
            }
        }

        for (int i = 0; i < pineapple_holes.Length; i++)
        {
            if (pineapple_holes[i].activeInHierarchy == true)
            {
                holeCount++;
            }
        }
        ObjectiveScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        StartCoroutine("waitingStart", 2);

        if (startTimer == true)
            timer += Time.deltaTime;

        if (holeCount <= 0)
        {
            pineapple_sad.SetActive(false);
            pineapple_happy.SetActive(true);

            Pass = true;
        }

        
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
            startTimer = true;
        }
    }
}

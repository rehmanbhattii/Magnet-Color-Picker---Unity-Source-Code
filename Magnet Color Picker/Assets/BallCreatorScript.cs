using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreatorScript : MonoBehaviour
{
    public int GreenBalls;
    public int YellowBalls;
    public int PinkBalls;

    public GameObject GreenBall;
    public GameObject YellowBall;
    public GameObject PinkBall;
    int i = 0;
    int j = 0;
    int k = 0;

    Vector3 GreenPos;
    Vector3 YellowPos;
    Vector3 PinkPos;

    // Start is called before the first frame update
    void Start()
    {
        YellowPos = new Vector3(transform.position.x + 2.5f, transform.position.y, transform.position.z);
        PinkPos = new Vector3(transform.position.x - 2.5f, transform.position.y, transform.position.z);

        StartCoroutine(GreenBallsInitialize());
        StartCoroutine(YellowBallsInitialize());
        StartCoroutine(PinkBallsInitialize());
    }
    IEnumerator GreenBallsInitialize()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(GreenBall, transform.position, transform.rotation);
        i++;
        if (i != GreenBalls)
            StartCoroutine(GreenBallsInitialize());
    }
    IEnumerator YellowBallsInitialize()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(YellowBall, YellowPos, transform.rotation);
        j++;
        if (j != YellowBalls)
            StartCoroutine(YellowBallsInitialize());
    }
    IEnumerator PinkBallsInitialize()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(PinkBall, PinkPos, transform.rotation);
        k++;
        if (k != PinkBalls)
            StartCoroutine(PinkBallsInitialize());
    }
}

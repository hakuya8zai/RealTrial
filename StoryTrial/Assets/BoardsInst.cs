using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardsInst : MonoBehaviour
{
    public GameObject[] boards = new GameObject[1];
    public GameObject[] preboards = new GameObject[4];
    public GameObject[] theboards = new GameObject[4];
    int X = 0;
    int Y = 0;

    public static bool BornCall = false;
    private Ray ifBornRay;

    int theFour = 1;
    private int theRandom_a;
    private int theRandom_b;
    public int boardsDeleteCount = 0;

    //x要*3
    private void Awake()
    {
        BornCall = false;

    }

    void Start()
    {
        for(int i = 0; i < 1; i++)
        {
            BoardsBorn();
        }


    }
    
    void Update()
    {//如果分數高於多少，deletecount增加

        if (BornCall == true)
        {
            BornCall = false;
            BornTest();
        }


        if (ScoreManage.score <= 10)
        { boardsDeleteCount = 0; }
        else if (ScoreManage.score <= 60 && ScoreManage.score > 10)
        { boardsDeleteCount = 1; }
        else if (ScoreManage.score <= 150 && ScoreManage.score > 60)
        { boardsDeleteCount = 2; }
        else if (ScoreManage.score <= 250 && ScoreManage.score > 150)
        { boardsDeleteCount = 3; }
        else if (ScoreManage.score <= 400 && ScoreManage.score > 250)
        { boardsDeleteCount = 4; }
        else if (ScoreManage.score > 400)
        { boardsDeleteCount = 5; }



    }

    void BoardsBorn()
    {
        
        if (boardsDeleteCount == 0)
        {
            for (X = 0; X <= 3; X = X + 1)
            {
                theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
            }

            Y = Y + 3;
        }
        else if (boardsDeleteCount == 1)
        {        
            //生成四次則少一格一次
            if (theFour == 1)
            {
                theRandom_a = Random.Range(1, 4);
            }

            if(theFour == 4)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                theFour = 0;
            }
            else if(theFour == theRandom_a)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                for (int s = 0; s < 1; s++)
                {
                    theboards[Random.Range(0, theboards.Length)].SetActive(false);
                }
            }
            else
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
            }
            Y = Y + 3;
            theFour = theFour + 1;
        }
        else if(boardsDeleteCount == 2)
        {
            //生成四次少一格兩次
            if(theFour == 1)
            {
                theRandom_a = Random.Range(1, 4);
            }

            if(theFour == 4)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                theFour = 0;
            }
            else if (theFour == theRandom_a)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
            }
            else
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                for (int s = 0; s < 1; s++)
                {
                    theboards[Random.Range(0, theboards.Length)].SetActive(false);
                }
            }
            Y = Y + 3;
            theFour = theFour + 1;
        }
        else if(boardsDeleteCount == 3)
        {
            //生成四次則少一格三次
            if (theFour == 4)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                theFour = 0;
            }
            else
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                for (int s = 0; s < 1; s++)
                {
                    theboards[Random.Range(0, theboards.Length)].SetActive(false);
                }
            }
            Y = Y + 3;
            theFour = theFour + 1;
        }
        else if(boardsDeleteCount == 4)
        {
            //生成四次 則少一格一次，少兩格一次
            if(theFour == 1)
            {
                theRandom_a = Random.Range(1, 4);
                theRandom_b = Random.Range(1, 4);
                if(theRandom_a == theRandom_b)
                {
                    if(theRandom_a == 1)
                    {
                        theRandom_b = Random.Range(2, 4);
                    }
                    else if(theRandom_a == 2)
                    { int w = Random.Range(0, 2);
                        if(w == 0)
                        {
                            theRandom_b = 1;
                        }
                        else if (w == 1)
                        {
                            theRandom_b = 3;
                        }
                        
                    }
                    else if (theRandom_a ==3)
                    {
                        theRandom_b = Random.Range(1, 3);
                    }
                }
            }

            if (theFour == 4)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                theFour = 0;
            }
            else if (theFour == theRandom_a)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                for (int s = 0; s < 1; s++)
                {
                    theboards[Random.Range(0, theboards.Length)].SetActive(false);
                }
            }
            else if (theFour == theRandom_b)
            {
                int w = Random.Range(0, 4);
                int v = 0;
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }

                if (w == 0)
                {
                    v = Random.Range(1, 4);
                }
                else if(w == 1)
                {
                    int z = Random.Range(0, 2);
                    if(z == 0)
                    {
                        v = 0;
                    }
                    else if(z ==1)
                    {
                        v = Random.Range(2, 4);
                    }
                }
                else if(w ==2)
                {
                    int z = Random.Range(0, 2);
                    if (z == 0)
                    {
                        v = Random.Range(0, 2);
                    }
                    else if (z == 1)
                    {
                        v = 3;
                    }
                }
                else if (w ==3)
                {
                    v = Random.Range(0, 3);
                }
                theboards[w].SetActive(false);
                theboards[v].SetActive(false);
            }
            else
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }

            }


            Y = Y + 3;
            theFour = theFour + 1;

        }
        else if(boardsDeleteCount == 5)
        {
            //生成四次，則少一格兩次，少兩格一次

            if (theFour == 1)
            {
                theRandom_a = Random.Range(1, 4);
            }

            if (theFour == 4)
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                theFour = 0;
            }
            else if (theFour == theRandom_a)
            {

                int w = Random.Range(0, 4);
                int v = 0;
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }

                if (w == 0)
                {
                    v = Random.Range(1, 4);
                }
                else if (w == 1)
                {
                    int z = Random.Range(0, 2);
                    if (z == 0)
                    {
                        v = 0;
                    }
                    else if (z == 1)
                    {
                        v = Random.Range(2, 4);
                    }
                }
                else if (w == 2)
                {
                    int z = Random.Range(0, 2);
                    if (z == 0)
                    {
                        v = Random.Range(0,2);
                    }
                    else if (z == 1)
                    {
                        v = 3;
                    }
                }
                else if (w == 3)
                {
                    v = Random.Range(0, 3);
                }
                theboards[w].SetActive(false);
                theboards[v].SetActive(false);
            }
            else
            {
                for (X = 0; X <= 3; X = X + 1)
                {
                    theboards[X] = Instantiate(boards[0], new Vector3(X * 3, Y, 0), Quaternion.identity);
                }
                for (int s = 0; s < 1; s++)
                {
                    theboards[Random.Range(0, theboards.Length)].SetActive(false);
                }
            }
            Y = Y + 3;
            theFour = theFour + 1;
        }





    }

    public void BornTest()
    {
        

            ifBornRay = new Ray(new Vector3(-5, CameraFollow.target.transform.position.y + 21, 0.2f), new Vector3(1, 0, 0));
            if (Physics.Raycast(ifBornRay) == false)
            {
                BoardsBorn();
            }
            
        





    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour {

    private int[,] cells = new int[3, 3];
    private int flagForPlayer = 1;

	// Use this for initialization
	void Start ()
    {
        reset();	
	}

    private void OnGUI()
    {
        if(GUI.Button(new Rect(325, 30, 100, 50), "Reset"))
        {
            reset();
        }

        int result = getWinner();
        if(result == 2)
        {
            GUI.Label(new Rect(450, 50, 100, 50), "Tie!");
        } else if(result == 1)
        {
            GUI.Label(new Rect(450, 50, 100, 50), "Player1(O) Win!");
        }
        else if(result == -1)
        {
            GUI.Label(new Rect(450, 50, 100, 50), "Player2(X) Win!");
        } else
        {
            
        }

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if(cells[i, j] == 1)
                {
                    GUI.Button(new Rect(300 + i * 50, 100 + j * 50, 50, 50), "O");
                }
                if(cells[i, j] == -1)
                {
                    GUI.Button(new Rect(300 + i * 50, 100 + j * 50, 50, 50), "X");
                }

                if(GUI.Button(new Rect(300 + i * 50, 100 + j * 50, 50, 50), ""))
                {
                    if(result == 0)
                    {
                        cells[i, j] = flagForPlayer;
                        flagForPlayer = -flagForPlayer;
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void reset()
    {
        flagForPlayer = 1;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                cells[i, j] = 0;
            }
        }
    }

    // 2 for no winner, 1 for P1, -1 for p2
    int getWinner()
    {
        //row
        for(int i = 0; i < 3; i++)
        {
            if(cells[i, 0] != 0)
            {
                if(cells[i, 0] == cells[i, 1] && cells[i, 1] == cells[i, 2])
                {
                    return cells[i, 0];
                }
            }
        }

        //column
        for (int i = 0; i < 3; i++)
        {
            if (cells[0,i] != 0)
            {
                if (cells[0, i] == cells[1, i] && cells[1, i] == cells[2, i])
                {
                    return cells[0, i];
                }
            }
        }

        //diagonal
        if(cells[0, 0] != 0)
        {
            if(cells[0, 0] == cells[1, 1] && cells[1, 1] == cells[2, 2])
            {
                return cells[0, 0];
            }
        }
        if (cells[0, 2] != 0)
        {
            if (cells[0, 2] == cells[1, 1] && cells[1, 1] == cells[2, 0])
            {
                return cells[2, 0];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (cells[i, j] == 0) return 0;
            }
        }

        //tie
        return 2;
    }



}

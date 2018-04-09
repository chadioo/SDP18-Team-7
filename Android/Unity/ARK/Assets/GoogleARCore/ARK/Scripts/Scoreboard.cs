﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scoreboard : MonoBehaviour {

    // IMPORT SCORE
    /*
    public GameObject scoreObj;
    private SoccerGameController originalScript;
    private int originalScore;
    */
    // SCORE LIST
    public Text Score1;
    public Text Score2;
    public Text Score3;
    public Text Score4;
    public Text Score5;
    public Text Score6;
    public Text Score7;
    public Text Score8;
    public Text Score9;
    public Text Score10;

    public Text Name1;
    public Text Name2;
    public Text Name3;
    public Text Name4;
    public Text Name5;
    public Text Name6;
    public Text Name7;
    public Text Name8;
    public Text Name9;
    public Text Name10;

    int newScore;
    int[] scoreBoardScores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    string[] scoreBoardNames = { "", "", "", "", "", "", "", "", "", "" };

    void Start() {
        calculateScoreBoard();
        initNames();
    }

    public void calculateScoreBoard()
    {
        System.IO.StreamWriter writer;
        System.IO.StreamReader reader;

        string newScorePath = "/ARKscore.txt";
        string scoreBoardPath = "/ARKscoreBoard.txt";
        string line;

        // check if new score has been saved
        if (!File.Exists(Application.persistentDataPath + newScorePath))
        {
            Debug.Log("No score has been saved");
        }
        // retrieve new score and store in var
        else
        {
            Debug.Log("A score has been saved");
            reader = new System.IO.StreamReader(Application.persistentDataPath + newScorePath);
            while ((line = reader.ReadLine()) != null)
            {
                Debug.Log("ARK LOG ********** Saved Score: " + line);
            }
            reader.Close();

            // check if scoreboard exists
            if (!File.Exists(Application.persistentDataPath + scoreBoardPath))
            {
                Debug.Log("No high scores have been saved");
            }
            // retrieve old scores and store in array
            else {
                Debug.Log("A scoreboard has been saved");
                reader = new System.IO.StreamReader(Application.persistentDataPath + newScorePath);
                int count = 0;
                while ((line = reader.ReadLine()) != null && count<10)
                {
                    Debug.Log("ARK LOG ********** High Score "+count+": " + line);

                    scoreBoardScores[count] = int.Parse(line);  // might switch to try parse
                    count++;
                    // need to include code for saving names strings
                }
                reader.Close();

                // insert new score into this list

                // if we will insert, need way to add name

                // resave over data stored in array if needed

            }
        }

    }


    public void initNames() {
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];
        Score1.text = scoreBoardScores[0];

        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
        Name1.text = scoreBoardNames[0];
    }

}

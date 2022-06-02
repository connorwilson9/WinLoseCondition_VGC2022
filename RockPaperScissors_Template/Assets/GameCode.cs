using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameCode : MonoBehaviour
{
    public SpriteRenderer theirRock;
    public SpriteRenderer theirPaper;
    public SpriteRenderer theirScissors;
    public SpriteRenderer yourRock;
    public SpriteRenderer yourPaper;
    public SpriteRenderer yourScissors;
    public TMP_Text scoreText;
    public TMP_Text winText;
    public Button press;


    private int yourScore = 0;
    private int theirScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        press.onClick.AddListener(ReRoll);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReRoll(){

        yourRock.enabled = false;
        yourPaper.enabled = false;
        yourScissors.enabled = false;
        theirRock.enabled = false;
        theirPaper.enabled = false;
        theirScissors.enabled = false;

        int yourSelect = Random.Range(0, 3);
        int theirSelect = Random.Range(0, 3);

        if(yourSelect == 0){
            yourRock.enabled = true;
        }
        else if(yourSelect == 1){
            yourPaper.enabled = true;
        }
        else if(yourSelect == 2){
            yourScissors.enabled = true;
        }


        if(theirSelect == 0){
            theirRock.enabled = true;
        }
        else if(theirSelect == 1){
            theirPaper.enabled = true;
        }
        else if(theirSelect == 2){
            theirScissors.enabled = true;
        }

        //0 = Rock, 1 = Paper, 2 = Scissors

        if(yourSelect == 0 && theirSelect == 1){
            //Rock - Paper
        }
        else if(yourSelect == 0 && theirSelect == 2){
            //Rock - Scissors
        }
        else if(yourSelect == 1 && theirSelect == 0){
            //Paper - Rock
        }
        else if(yourSelect == 1 && theirSelect == 2){
            //Paper - Scissors
        }
        else if(yourSelect == 2 && theirSelect == 0){
            //Scissors - Rock
        }
        else if(yourSelect == 2 && theirSelect == 1){
            //Scissors - Paper
        }





    }
}

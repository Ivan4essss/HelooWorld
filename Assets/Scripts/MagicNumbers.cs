using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    public int min = 1;
    public int max = 1000;
    int guess;
    int click;
    public int count = 0;
    public int minGame;
    public int maxGame;

   



    // Start is called before the first frame update
    void Start()
    {
        minGame = min;
        maxGame = max;


        print("Загадай число " + min + "до " + max);
        guess = (min + max) / 2;
        print("Ваше число " + guess + "?");
    





    }


    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;

            count = click;
            UpdateGuess();
            click = count + 1;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            count = click;
            UpdateGuess();
            click = count + 1;

        }




        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Всё, пиздец!");
            print(" Вы угадали за " + click + " ходов");



        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restart();

        }


    }

    void UpdateGuess()
    {
        print("Загадай число " + max + "до " + max);
        guess = (min + max) / 2;
        print("Ваше число " + guess + "?");






    }
    void Restart()
    {
        min = minGame;
        max = maxGame;
        Start();
    }






}







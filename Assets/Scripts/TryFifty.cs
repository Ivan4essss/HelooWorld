﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryFifty : MonoBehaviour
{

    public int click;
    public int sum;

    public bool gameFinish;










    // Start is called before the first frame update
    void Start()
    {
        initGame();

    }

    private void initGame()
    {
        click = 0;
        gameFinish = false;
        sum = 0;

        print("Ваша цель достигнуть числа 50 складывая числа на клавиатуре");
        print("У вас сейчас " + click);
        print("Начинайте!!!");
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            handleButton(0);

        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            handleButton(1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            handleButton(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            handleButton(3);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            handleButton(4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            handleButton(5);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            handleButton(6);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            handleButton(7);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            handleButton(8);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            handleButton(9);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space press");
            initGame();
        }








    }

    private void handleButton(int value)
    {
        sum += value;

        print(sum);
        click++;
        gameFinish = sum >= 50;


        if (gameFinish)
        {
            if (sum == 50)
            {
                print("Вы победили");

            }
            else
            {
                print("Вы проиграли");
            }
            print("За " + click + " ходов");

            print("Push Space to restart");
        }

    }





}

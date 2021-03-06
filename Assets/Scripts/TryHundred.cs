using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryHundred : MonoBehaviour
{
    public int sum;
    public int click;
    bool finish = false;



    // Start is called before the first frame update
    public void Start()
    {
        reStart();
    }
    private void reStart()
    {
        sum = 0;
        click = 0;
        print("Ваша цель достигнуть числа 50 складывая числа на клавиатуре");
        print("У вас сейчас " + click + " ходов");
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
            print("Pussh space to restart");
            reStart();
        }

    }
    void handleButton(int value)
    {
        sum += value;
        print(sum);
        click++;
        finish = sum >= 50;
        if (finish)
        {
            if (finish = sum == 50)
            {
                print("Поздравляем, вы выйграли!");
                print("За " + click + " шагов");
            }
            else 
            {
                print("УАПУАПУАП УАААААААП!");
            }

        }
         


    }

}

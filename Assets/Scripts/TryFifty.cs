using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryFifty : MonoBehaviour
{
    int zero = 0;
    int click;
    int sum;
    int answer;
 







    // Start is called before the first frame update
    void Start()
    {

        print("Ваша цель достигнуть числа 50 складывая числа на клавиатуре");
        print("У вас сейчас " + zero);
        print("Начинайте!!!");
        sum = zero;






    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            answer = sum + zero;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;



        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            answer = sum + 1;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;



        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            answer = sum + 2;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            answer = sum + 3;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            answer = sum + 4;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            answer = sum + 5;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            answer = sum + 6;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            answer = sum + 7;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            answer = sum + 8;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;


        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            answer = sum + 9;
            sum = answer;
            print(sum);
            click = zero + 1;
            zero = click;

        }
        bool isMatch;
        isMatch = sum == 50;
        if (isMatch)
        {
            print("Вы победили");
            print("За " + zero + " ходов");


        }
         
        


  






    }


}

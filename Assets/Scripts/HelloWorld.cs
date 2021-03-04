using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        //int enemyhealth;


        //print(playerhealth);

        //enemyhealth = playerhealth + 10 / 2;
        //print(enemyhealth);


        //float damage = 4.5f;
        //playerhealth = (int)damage;

        //string playername;
        //playername = "Alex";

        //print("Hello " + playername + "your health " + playerhealth);

        //bool isAlive;
        //isAlive = playerhealth > 0 || enemyhealth > 0;

        //print("is player alive: " + isAlive);

        bool isAlive = true;
        int playerhealth = -100; //обявили переменную с именем и типом

        if (playerhealth > 0)
        {
            print("Player alive!");

        }
        else
        {
            //false
            print("Player not alive");


        }







    }

    // Update is called once per frame
    void Update()
    {
        //print("update");
    }
}

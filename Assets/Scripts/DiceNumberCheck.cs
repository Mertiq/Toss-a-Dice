using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceNumberCheck : MonoBehaviour
{
    Vector3 diceVelocity;
    void FixedUpdate()
    {
        diceVelocity = Dice.dVelocity;
    }

    private void OnTriggerStay(Collider other)
    {
        if(diceVelocity == Vector3.zero)
        {
            Debug.Log(other.gameObject.name);
            switch (other.gameObject.name)
            {
                case "side 1":
                    Dice.number = 6;
                    break;
                case "side 2":
                    Dice.number = 5;
                    break;
                case "side 3":
                    Dice.number = 4;
                    break;
                case "side 4":
                    Dice.number = 3;
                    break;
                case "side 5":
                    Dice.number = 2;
                    break;
                case "side 6":
                    Dice.number = 1;
                    break;
            }
        }
    }
}

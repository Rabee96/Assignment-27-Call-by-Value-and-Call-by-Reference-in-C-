using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment27
{
    public class NewBehaviourScript : MonoBehaviour
    {
        int number1;
        int number2;
        int number3;
        // Start is called before the first frame update
        void Start()
        {
            number1 = 9;
            number2 = 7;
            
            int result = multiplyBy10(number1);
            Debug.Log("number1 : "+ number1);
            Debug.Log("result :"+ result);
            Debug.Log("number1 : "+ number1);

            Debug.Log("number2 : "+ number2);
            multiplyByRef(ref number2);
            Debug.Log("number2 : "+ number2);

            
            multiplyByOut(out number3);
            Debug.Log("number3 : "+ number3);

        }
        int multiplyBy10(int number){
            return number * 10;
        }

        void multiplyByRef(ref int number){
            number *= 100;
        }
        void multiplyByOut(out int number){
            number = 5;
            number *=    1000;
        }
    }
}
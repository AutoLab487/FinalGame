using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer: MonoBehaviour
{
    public string value, value1;
    public InputField inputField, inputField1, inputField2, inputField3, inputField4,inputField5;
    public GameObject display_text;
    private bool correct, correct1, correct2, correct3, correct4;
    public GameObject GameWinpopUp, GameLosepopUp;

    public void check1()
    {
        if (inputField4.text == "0")
        {
            correct4 = true;
        }
    }
    public void Validate1()
    {
        if (correct4)
        {
        GameWinpopUp.SetActive(true);
        }
        else
        {
            GameLosepopUp.SetActive(true);
        }
    }
    public void check2()
    {

    }








    public void check3()
    {
        if (inputField.text == "A")
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
        value = inputField.text;
        //display_text = inputField.GetComponent<Text>().text = "this " + value + " this is input";

        if (inputField1.text == "A")
        {
            correct1 = true;
        }
        else
        {
            correct1 = false;
        }
        value1 = inputField1.text;

        if (inputField2.text == "B")
        {
            correct2 = true;
        }
        else
        {
            correct2 = false;
        }
        value1 = inputField2.text;

        if (inputField3.text == "B")
        {
            correct3 = true;
        }
        else
        {
            correct3 = false;
        }
        value1 = inputField2.text;
        //validate();

    }


    public void validate3()
    {   if (correct == true && correct1==true && correct2==true && correct3==true)//(correct && correct1  && correct2 && correct3)
        {
            //Debug.Log("asdas");
            GameWinpopUp.SetActive(true);

        }
        //value = inputField.text;
        //display_text = inputField.GetComponent<Text>().text = "this " + value + " this is input";
        else
        {
            GameLosepopUp.SetActive(true);
        }

    }
    


}

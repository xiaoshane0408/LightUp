using UnityEngine;
using UnityEngine.UI;

public class LightBtnCtrl : MonoBehaviour
{
    public ButtonSet[] buttons = new ButtonSet[16];
    public Sprite white;
    public Sprite black;
    public GameObject Panel;

    public void Reset()
    {
        // 初始值 - 全暗
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Image>().sprite = black;
            buttons[i].flag = false;
        }
        Panel.SetActive(false);
    }

    public void CheckWin()
    {
        int count = 0;
        for(int i = 0; i < buttons.Length; i++)
        {
            if(buttons[i].flag == true)
            {
                count += 1;
            }
        }
        if (count == 16)
        {
            Debug.Log("win");
            PanelOpen();
        }
    }
    #region PanelSet
    public void PanelOpen()
    {
        Panel.SetActive(true);
    }
    public void PanelClose()
    {
        Panel.SetActive(false);
    }
    #endregion

    #region btn0
    public void Onclickbtn0()
    {
        // btn0
        if (!buttons[0].flag)
        {
            buttons[0].GetComponent<Image>().sprite = white;
            buttons[0].flag = true;
            Debug.Log(buttons[0].name + buttons[0].flag);
        }
        else
        {
            buttons[0].GetComponent<Image>().sprite = black;
            buttons[0].flag = false;
            Debug.Log(buttons[0].name + buttons[0].flag);
        }
        // btn1
        if (!buttons[1].flag)
        {
            buttons[1].GetComponent<Image>().sprite = white;
            buttons[1].flag = true;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        else
        {
            buttons[1].GetComponent<Image>().sprite = black;
            buttons[1].flag = false;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        // btn4
        if (!buttons[4].flag)
        {
            buttons[4].GetComponent<Image>().sprite = white;
            buttons[4].flag = true;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        else
        {
            buttons[4].GetComponent<Image>().sprite = black;
            buttons[4].flag = false;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn1
    public void Onclickbtn1()
    {
        // btn0
        if (!buttons[0].flag)
        {
            buttons[0].GetComponent<Image>().sprite = white;
            buttons[0].flag = true;
            Debug.Log(buttons[0].name + buttons[0].flag);
        }
        else
        {
            buttons[0].GetComponent<Image>().sprite = black;
            buttons[0].flag = false;
            Debug.Log(buttons[0].name + buttons[0].flag);
        }
        // btn1
        if (!buttons[1].flag)
        {
            buttons[1].GetComponent<Image>().sprite = white;
            buttons[1].flag = true;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        else
        {
            buttons[1].GetComponent<Image>().sprite = black;
            buttons[1].flag = false;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        // btn2
        if (!buttons[2].flag)
        {
            buttons[2].GetComponent<Image>().sprite = white;
            buttons[2].flag = true;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        else
        {
            buttons[2].GetComponent<Image>().sprite = black;
            buttons[2].flag = false;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        // btn5
        if (!buttons[5].flag)
        {
            buttons[5].GetComponent<Image>().sprite = white;
            buttons[5].flag = true;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        else
        {
            buttons[5].GetComponent<Image>().sprite = black;
            buttons[5].flag = false;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn2
    public void Onclickbtn2()
    {
        // btn1
        if (!buttons[1].flag)
        {
            buttons[1].GetComponent<Image>().sprite = white;
            buttons[1].flag = true;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        else
        {
            buttons[1].GetComponent<Image>().sprite = black;
            buttons[1].flag = false;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        // btn2
        if (!buttons[2].flag)
        {
            buttons[2].GetComponent<Image>().sprite = white;
            buttons[2].flag = true;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        else
        {
            buttons[2].GetComponent<Image>().sprite = black;
            buttons[2].flag = false;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        // btn3
        if (!buttons[3].flag)
        {
            buttons[3].GetComponent<Image>().sprite = white;
            buttons[3].flag = true;
            Debug.Log(buttons[3].name + buttons[3].flag);
        }
        else
        {
            buttons[3].GetComponent<Image>().sprite = black;
            buttons[3].flag = false;
            Debug.Log(buttons[3].name + buttons[3].flag);
        }
        // btn6
        if (!buttons[6].flag)
        {
            buttons[6].GetComponent<Image>().sprite = white;
            buttons[6].flag = true;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        else
        {
            buttons[6].GetComponent<Image>().sprite = black;
            buttons[6].flag = false;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn3
    public void Onclickbtn3()
    {
        // btn2
        if (!buttons[2].flag)
        {
            buttons[2].GetComponent<Image>().sprite = white;
            buttons[2].flag = true;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        else
        {
            buttons[2].GetComponent<Image>().sprite = black;
            buttons[2].flag = false;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        // btn3
        if (!buttons[3].flag)
        {
            buttons[3].GetComponent<Image>().sprite = white;
            buttons[3].flag = true;
            Debug.Log(buttons[3].name + buttons[3].flag);
        }
        else
        {
            buttons[3].GetComponent<Image>().sprite = black;
            buttons[3].flag = false;
            Debug.Log(buttons[3].name + buttons[3].flag);
        }
        // btn7
        if (!buttons[7].flag)
        {
            buttons[7].GetComponent<Image>().sprite = white;
            buttons[7].flag = true;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        else
        {
            buttons[7].GetComponent<Image>().sprite = black;
            buttons[7].flag = false;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn4
    public void Onclickbtn4()
    {
        // btn0
        if (!buttons[0].flag)
        {
            buttons[0].GetComponent<Image>().sprite = white;
            buttons[0].flag = true;
            Debug.Log(buttons[0].name + buttons[0].flag);
        }
        else
        {
            buttons[0].GetComponent<Image>().sprite = black;
            buttons[0].flag = false;
            Debug.Log(buttons[0].name + buttons[0].flag);
        }
        // btn4
        if (!buttons[4].flag)
        {
            buttons[4].GetComponent<Image>().sprite = white;
            buttons[4].flag = true;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        else
        {
            buttons[4].GetComponent<Image>().sprite = black;
            buttons[4].flag = false;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        // btn5
        if (!buttons[5].flag)
        {
            buttons[5].GetComponent<Image>().sprite = white;
            buttons[5].flag = true;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        else
        {
            buttons[5].GetComponent<Image>().sprite = black;
            buttons[5].flag = false;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        // btn8
        if (!buttons[8].flag)
        {
            buttons[8].GetComponent<Image>().sprite = white;
            buttons[8].flag = true;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        else
        {
            buttons[8].GetComponent<Image>().sprite = black;
            buttons[8].flag = false;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn5
    public void Onclickbtn5()
    {
        // btn1
        if (!buttons[1].flag)
        {
            buttons[1].GetComponent<Image>().sprite = white;
            buttons[1].flag = true;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        else
        {
            buttons[1].GetComponent<Image>().sprite = black;
            buttons[1].flag = false;
            Debug.Log(buttons[1].name + buttons[1].flag);
        }
        // btn4
        if (!buttons[4].flag)
        {
            buttons[4].GetComponent<Image>().sprite = white;
            buttons[4].flag = true;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        else
        {
            buttons[4].GetComponent<Image>().sprite = black;
            buttons[4].flag = false;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        // btn5
        if (!buttons[5].flag)
        {
            buttons[5].GetComponent<Image>().sprite = white;
            buttons[5].flag = true;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        else
        {
            buttons[5].GetComponent<Image>().sprite = black;
            buttons[5].flag = false;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        // btn6
        if (!buttons[6].flag)
        {
            buttons[6].GetComponent<Image>().sprite = white;
            buttons[6].flag = true;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        else
        {
            buttons[6].GetComponent<Image>().sprite = black;
            buttons[6].flag = false;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        // btn9
        if (!buttons[9].flag)
        {
            buttons[9].GetComponent<Image>().sprite = white;
            buttons[9].flag = true;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        else
        {
            buttons[9].GetComponent<Image>().sprite = black;
            buttons[9].flag = false;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn6
    public void Onclickbtn6()
    {
        // btn2
        if (!buttons[2].flag)
        {
            buttons[2].GetComponent<Image>().sprite = white;
            buttons[2].flag = true;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        else
        {
            buttons[2].GetComponent<Image>().sprite = black;
            buttons[2].flag = false;
            Debug.Log(buttons[2].name + buttons[2].flag);
        }
        // btn5
        if (!buttons[5].flag)
        {
            buttons[5].GetComponent<Image>().sprite = white;
            buttons[5].flag = true;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        else
        {
            buttons[5].GetComponent<Image>().sprite = black;
            buttons[5].flag = false;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        // btn6
        if (!buttons[6].flag)
        {
            buttons[6].GetComponent<Image>().sprite = white;
            buttons[6].flag = true;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        else
        {
            buttons[6].GetComponent<Image>().sprite = black;
            buttons[6].flag = false;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        // btn7
        if (!buttons[7].flag)
        {
            buttons[7].GetComponent<Image>().sprite = white;
            buttons[7].flag = true;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        else
        {
            buttons[7].GetComponent<Image>().sprite = black;
            buttons[7].flag = false;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        // btn10
        if (!buttons[10].flag)
        {
            buttons[10].GetComponent<Image>().sprite = white;
            buttons[10].flag = true;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        else
        {
            buttons[10].GetComponent<Image>().sprite = black;
            buttons[10].flag = false;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn7
    public void Onclickbtn7()
    {
        // btn3
        if (!buttons[3].flag)
        {
            buttons[3].GetComponent<Image>().sprite = white;
            buttons[3].flag = true;
            Debug.Log(buttons[3].name + buttons[3].flag);
        }
        else
        {
            buttons[3].GetComponent<Image>().sprite = black;
            buttons[3].flag = false;
            Debug.Log(buttons[3].name + buttons[3].flag);
        }
        // btn6
        if (!buttons[6].flag)
        {
            buttons[6].GetComponent<Image>().sprite = white;
            buttons[6].flag = true;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        else
        {
            buttons[6].GetComponent<Image>().sprite = black;
            buttons[6].flag = false;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        // btn7
        if (!buttons[7].flag)
        {
            buttons[7].GetComponent<Image>().sprite = white;
            buttons[7].flag = true;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        else
        {
            buttons[7].GetComponent<Image>().sprite = black;
            buttons[7].flag = false;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        // btn11
        if (!buttons[11].flag)
        {
            buttons[11].GetComponent<Image>().sprite = white;
            buttons[11].flag = true;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        else
        {
            buttons[11].GetComponent<Image>().sprite = black;
            buttons[11].flag = false;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn8
    public void Onclickbtn8()
    {
        // btn4
        if (!buttons[4].flag)
        {
            buttons[4].GetComponent<Image>().sprite = white;
            buttons[4].flag = true;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        else
        {
            buttons[4].GetComponent<Image>().sprite = black;
            buttons[4].flag = false;
            Debug.Log(buttons[4].name + buttons[4].flag);
        }
        // btn8
        if (!buttons[8].flag)
        {
            buttons[8].GetComponent<Image>().sprite = white;
            buttons[8].flag = true;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        else
        {
            buttons[8].GetComponent<Image>().sprite = black;
            buttons[8].flag = false;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        // btn9
        if (!buttons[9].flag)
        {
            buttons[9].GetComponent<Image>().sprite = white;
            buttons[9].flag = true;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        else
        {
            buttons[9].GetComponent<Image>().sprite = black;
            buttons[9].flag = false;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        // btn12
        if (!buttons[12].flag)
        {
            buttons[12].GetComponent<Image>().sprite = white;
            buttons[12].flag = true;
            Debug.Log(buttons[12].name + buttons[12].flag);
        }
        else
        {
            buttons[12].GetComponent<Image>().sprite = black;
            buttons[12].flag = false;
            Debug.Log(buttons[12].name + buttons[12].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn9
    public void Onclickbtn9()
    {
        // btn5
        if (!buttons[5].flag)
        {
            buttons[5].GetComponent<Image>().sprite = white;
            buttons[5].flag = true;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        else
        {
            buttons[5].GetComponent<Image>().sprite = black;
            buttons[5].flag = false;
            Debug.Log(buttons[5].name + buttons[5].flag);
        }
        // btn8
        if (!buttons[8].flag)
        {
            buttons[8].GetComponent<Image>().sprite = white;
            buttons[8].flag = true;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        else
        {
            buttons[8].GetComponent<Image>().sprite = black;
            buttons[8].flag = false;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        // btn9
        if (!buttons[9].flag)
        {
            buttons[9].GetComponent<Image>().sprite = white;
            buttons[9].flag = true;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        else
        {
            buttons[9].GetComponent<Image>().sprite = black;
            buttons[9].flag = false;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        // btn10
        if (!buttons[10].flag)
        {
            buttons[10].GetComponent<Image>().sprite = white;
            buttons[10].flag = true;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        else
        {
            buttons[10].GetComponent<Image>().sprite = black;
            buttons[10].flag = false;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        // btn13
        if (!buttons[13].flag)
        {
            buttons[13].GetComponent<Image>().sprite = white;
            buttons[13].flag = true;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        else
        {
            buttons[13].GetComponent<Image>().sprite = black;
            buttons[13].flag = false;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn10
    public void Onclickbtn10()
    {
        // btn6
        if (!buttons[6].flag)
        {
            buttons[6].GetComponent<Image>().sprite = white;
            buttons[6].flag = true;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        else
        {
            buttons[6].GetComponent<Image>().sprite = black;
            buttons[6].flag = false;
            Debug.Log(buttons[6].name + buttons[6].flag);
        }
        // btn9
        if (!buttons[9].flag)
        {
            buttons[9].GetComponent<Image>().sprite = white;
            buttons[9].flag = true;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        else
        {
            buttons[9].GetComponent<Image>().sprite = black;
            buttons[9].flag = false;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        // btn10
        if (!buttons[10].flag)
        {
            buttons[10].GetComponent<Image>().sprite = white;
            buttons[10].flag = true;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        else
        {
            buttons[10].GetComponent<Image>().sprite = black;
            buttons[10].flag = false;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        // btn11
        if (!buttons[11].flag)
        {
            buttons[11].GetComponent<Image>().sprite = white;
            buttons[11].flag = true;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        else
        {
            buttons[11].GetComponent<Image>().sprite = black;
            buttons[11].flag = false;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        // btn14
        if (!buttons[14].flag)
        {
            buttons[14].GetComponent<Image>().sprite = white;
            buttons[14].flag = true;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        else
        {
            buttons[14].GetComponent<Image>().sprite = black;
            buttons[14].flag = false;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn11
    public void Onclickbtn11()
    {
        // btn7
        if (!buttons[7].flag)
        {
            buttons[7].GetComponent<Image>().sprite = white;
            buttons[7].flag = true;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        else
        {
            buttons[7].GetComponent<Image>().sprite = black;
            buttons[7].flag = false;
            Debug.Log(buttons[7].name + buttons[7].flag);
        }
        // btn10
        if (!buttons[10].flag)
        {
            buttons[10].GetComponent<Image>().sprite = white;
            buttons[10].flag = true;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        else
        {
            buttons[10].GetComponent<Image>().sprite = black;
            buttons[10].flag = false;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        // btn11
        if (!buttons[11].flag)
        {
            buttons[11].GetComponent<Image>().sprite = white;
            buttons[11].flag = true;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        else
        {
            buttons[11].GetComponent<Image>().sprite = black;
            buttons[11].flag = false;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        // btn15
        if (!buttons[15].flag)
        {
            buttons[15].GetComponent<Image>().sprite = white;
            buttons[15].flag = true;
            Debug.Log(buttons[15].name + buttons[15].flag);
        }
        else
        {
            buttons[15].GetComponent<Image>().sprite = black;
            buttons[15].flag = false;
            Debug.Log(buttons[15].name + buttons[15].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn12
    public void Onclickbtn12()
    {
        // btn8
        if (!buttons[8].flag)
        {
            buttons[8].GetComponent<Image>().sprite = white;
            buttons[8].flag = true;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        else
        {
            buttons[8].GetComponent<Image>().sprite = black;
            buttons[8].flag = false;
            Debug.Log(buttons[8].name + buttons[8].flag);
        }
        // btn12
        if (!buttons[12].flag)
        {
            buttons[12].GetComponent<Image>().sprite = white;
            buttons[12].flag = true;
            Debug.Log(buttons[12].name + buttons[12].flag);
        }
        else
        {
            buttons[12].GetComponent<Image>().sprite = black;
            buttons[12].flag = false;
            Debug.Log(buttons[12].name + buttons[12].flag);
        }
        // btn13
        if (!buttons[13].flag)
        {
            buttons[13].GetComponent<Image>().sprite = white;
            buttons[13].flag = true;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        else
        {
            buttons[13].GetComponent<Image>().sprite = black;
            buttons[13].flag = false;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn13
    public void Onclickbtn13()
    {
        // btn9
        if (!buttons[9].flag)
        {
            buttons[9].GetComponent<Image>().sprite = white;
            buttons[9].flag = true;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        else
        {
            buttons[9].GetComponent<Image>().sprite = black;
            buttons[9].flag = false;
            Debug.Log(buttons[9].name + buttons[9].flag);
        }
        // btn12
        if (!buttons[12].flag)
        {
            buttons[12].GetComponent<Image>().sprite = white;
            buttons[12].flag = true;
            Debug.Log(buttons[12].name + buttons[12].flag);
        }
        else
        {
            buttons[12].GetComponent<Image>().sprite = black;
            buttons[12].flag = false;
            Debug.Log(buttons[12].name + buttons[12].flag);
        }
        // btn13
        if (!buttons[13].flag)
        {
            buttons[13].GetComponent<Image>().sprite = white;
            buttons[13].flag = true;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        else
        {
            buttons[13].GetComponent<Image>().sprite = black;
            buttons[13].flag = false;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        // btn14
        if (!buttons[14].flag)
        {
            buttons[14].GetComponent<Image>().sprite = white;
            buttons[14].flag = true;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        else
        {
            buttons[14].GetComponent<Image>().sprite = black;
            buttons[14].flag = false;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn14
    public void Onclickbtn14()
    {
        // btn10
        if (!buttons[10].flag)
        {
            buttons[10].GetComponent<Image>().sprite = white;
            buttons[10].flag = true;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        else
        {
            buttons[10].GetComponent<Image>().sprite = black;
            buttons[10].flag = false;
            Debug.Log(buttons[10].name + buttons[10].flag);
        }
        // btn13
        if (!buttons[13].flag)
        {
            buttons[13].GetComponent<Image>().sprite = white;
            buttons[13].flag = true;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        else
        {
            buttons[13].GetComponent<Image>().sprite = black;
            buttons[13].flag = false;
            Debug.Log(buttons[13].name + buttons[13].flag);
        }
        // btn14
        if (!buttons[14].flag)
        {
            buttons[14].GetComponent<Image>().sprite = white;
            buttons[14].flag = true;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        else
        {
            buttons[14].GetComponent<Image>().sprite = black;
            buttons[14].flag = false;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        // btn15
        if (!buttons[15].flag)
        {
            buttons[15].GetComponent<Image>().sprite = white;
            buttons[15].flag = true;
            Debug.Log(buttons[15].name + buttons[15].flag);
        }
        else
        {
            buttons[15].GetComponent<Image>().sprite = black;
            buttons[15].flag = false;
            Debug.Log(buttons[15].name + buttons[15].flag);
        }
        CheckWin();
    }
    #endregion

    #region btn15
    public void Onclickbtn15()
    {
        // btn11
        if (!buttons[11].flag)
        {
            buttons[11].GetComponent<Image>().sprite = white;
            buttons[11].flag = true;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        else
        {
            buttons[11].GetComponent<Image>().sprite = black;
            buttons[11].flag = false;
            Debug.Log(buttons[11].name + buttons[11].flag);
        }
        // btn14
        if (!buttons[14].flag)
        {
            buttons[14].GetComponent<Image>().sprite = white;
            buttons[14].flag = true;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        else
        {
            buttons[14].GetComponent<Image>().sprite = black;
            buttons[14].flag = false;
            Debug.Log(buttons[14].name + buttons[14].flag);
        }
        // btn15
        if (!buttons[15].flag)
        {
            buttons[15].GetComponent<Image>().sprite = white;
            buttons[15].flag = true;
            Debug.Log(buttons[15].name + buttons[15].flag);
        }
        else
        {
            buttons[15].GetComponent<Image>().sprite = black;
            buttons[15].flag = false;
            Debug.Log(buttons[15].name + buttons[15].flag);
        }
        CheckWin();
    }
    #endregion

    void Start()
    {
        Reset();
    }
}

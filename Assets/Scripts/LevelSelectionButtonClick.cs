using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionButtonClick : MonoBehaviour {

    public Text ButtonText;

    public static int SelectedLevelNumber;

    public void OnClick()
    {

        for (int i = 1; i < 30; i++)
        {

            if (ButtonText.text == ""+i)
            {
                SelectedLevelNumber = i;
            }

            Application.LoadLevel(2);
        }
    }
    
}

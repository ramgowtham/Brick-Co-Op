using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionButtonClick : MonoBehaviour {

    public Text ButtonText;

    public static int SelectedLevelNumber;

   public  void OnClick()
    {
       if(ButtonText.text=="1")
        {
            SelectedLevelNumber = 1;
        }
        
        Application.LoadLevel(2);
    }
    
}

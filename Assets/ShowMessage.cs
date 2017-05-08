using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMessage : MonoBehaviour {
    
    public Text UIText;
    public void TryMessage(GameObject target)
    {
        UIMessage uiMessage = target.GetComponentInChildren<UIMessage>();
        if(uiMessage)
        {
            UIText.text = uiMessage.message;
        }
    }

    public void ClearMessage()
    {
        UIText.text = "";
    }
    
}

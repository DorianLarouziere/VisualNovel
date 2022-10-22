using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private GameObject Skip;
    [SerializeField] private Dialogues dialogues;


    public void Update(){
        if(scriptbtnnext.indexDialogue > dialogues.dialogues.Count -1){
            textComponent.text = "FIN";
            Destroy(GameObject.Find("ButtonNext(Clone)"));
        }
        else{
            textComponent.text = dialogues.dialogues[scriptbtnnext.indexDialogue];
            Debug.Log(textComponent.text);
        }
      
    }
}
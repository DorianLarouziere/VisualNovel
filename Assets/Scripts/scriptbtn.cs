using UnityEngine;
using TMPro;

public class scriptbtn : MonoBehaviour
{
    [SerializeField] GameObject Start;
    [SerializeField] GameObject Skip;
    [SerializeField] GameObject DialogueBoxContainer;
    [SerializeField] GameObject parent;
    public void Click(){
        Destroy(Start);

        var dialogue = Instantiate(DialogueBoxContainer, parent.transform);
        //var dialrect = dialogue.GetComponent<RectTransform>();
        //dialrect.position = new Vector3(0f, 0f, 0f);
        /*Left*/
        //dialrect.offsetMin.Set(0f,0f);
        /*Right*/
        //dialrect.offsetMax.Set(0f,0f);

        var skip = Instantiate(Skip, dialogue.transform);
        //skip.transform.SetParent(parent.transform);
        //var skiprect = skip.GetComponent<RectTransform>(); 
        //skiprect.localPosition = new Vector3(1017f, -564f, 0f);
    }
}

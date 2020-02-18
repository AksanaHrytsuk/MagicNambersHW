using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultScene : MonoBehaviour
{
    public Text resultText;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
       // int [] numbers = { 0, 5, 67, 85 };
       // Debug.Log("Befor for");
       // for (int i = 0; i < numbers.Length; i++){
       //Debug.Log("Inside for");
       //Debug.Log("After for");

       //text.text = "Hahaha";
       //text = FindObjectOfType<Text>();

        ICanGuess magicNumbers = FindObjectOfType<ICanGuess>();
        int number = magicNumbers.guess;
        resultText.text = "Ваше число?" + number;
       
        Text[] allText = FindObjectsOfType<Text>();
        for (int i = 0; i < allText.Length; i++) {
            allText[i].text = "Text" + i;
        };
    
        Destroy(magicNumbers.gameObject); //destroy gameobject
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

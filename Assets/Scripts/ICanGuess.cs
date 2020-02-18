using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ICanGuess : MonoBehaviour
{
  public int guess;
  public int minNumber;
  public int maxNumber;
  public int count;
  public Text qustion;

  // Start is called before the first frame update
  void Start()
  {
    count = 0;
    minNumber = 1;
    maxNumber = 1000;
    guess = Random.Range(minNumber, maxNumber + 1);
    
    {
      Progress();
      DontDestroyOnLoad(gameObject);
      Debug.Log("Start script" + gameObject);
    }
  }

  // Update is called once per frame
  void Update()
  {
  }
  //qustion.text = "Is your number " + guess.ToString() + "? \n  ";
  //guess = Random.Range(minNumber, maxNumber + 1);
  public void Less()
  {
    maxNumber = guess - 1;
    guess = Random.Range(minNumber, maxNumber + 1);
    Progress();
  }
  public void More()
  {
    minNumber = guess + 1;
    guess = Random.Range(minNumber, maxNumber + 1);
    Progress();
  }
  public void Progress()
  {
    count++;
    qustion.text = "Is your number " + guess.ToString() + "? \n Progress:  " + count.ToString();
  }
}

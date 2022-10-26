using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8Dialogue : MonoBehaviour{
  public int primeInt = 1;         // This integer drives game progress!
  public Text Char1name;
  public Text Char1speech;
  public Text Char2name;
  public Text Char2speech;
 //public Text Char3name;
 //public Text Char3speech;
  public GameObject DialogueDisplay;
  public GameObject ArtChar1;
 //public GameObject ArtChar2;
  public GameObject ArtBG1;
  public GameObject Choice1a;
  public GameObject Choice1b;
  public GameObject NextScene1Button;
  public GameObject NextScene2Button;
  public GameObject nextButton;
  public GameHandler gameHandler;
 //public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

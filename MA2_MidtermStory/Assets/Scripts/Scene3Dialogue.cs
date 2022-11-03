using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name; //alien
        public Text Char1speech;
        public Text Char2name; //pixeli
        public Text Char2speech;
        public Text Char3name; //Human1
        public Text Char3speech;
        public Text Char4name; //Human2
        public Text Char4speech;
        public Text Char5name; //Human3
        public Text Char5speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1; //Human1
        public GameObject ArtChar2; //Human2
        public GameObject ArtChar3; //Human3
        public GameObject ArtChar4; //Human4 (no dialogue)
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject NextScene5Button;
        public GameObject NextScene6Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
        NextScene5Button.SetActive(false);
        NextScene6Button.SetActive(false);
        nextButton.SetActive(true);

        if(GameHandler.hasAi==true){
          DialogueDisplay.SetActive(true);
          Char1name.text = "YOU";
          Char1speech.text = "Pixeli, do you have any information about this place? \nHave you surveyed the area?";
          Char2name.text = "";
          Char2speech.text = "";
          Char3name.text = "";
          Char3speech.text = "";
          Char4name.text = "";
          Char4speech.text = "";
          Char5name.text = "";
          Char5speech.text = "";
              primeInt=99;
            }
          else if ((GameHandler.hasComm == true)||(GameHandler.hasProof == true)){
              primeInt=1;
            }

}


void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
            }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
      }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(The amount of humans here..is overwhelming. \n(...) \n(The more the better I suppose.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
      }
      else if (primeInt == 3){
               Char1name.text = "YOU";
               Char1speech.text = "(Wait .. is that a little human?)";
               Char2name.text = "";
               Char2speech.text = "";
            }

       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "(It's coming toward me!)";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
              if (GameHandler.hasProof==true){
                NextScene2Button.SetActive(false);
        }
  }

       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "Yes: this area is urban and metropolitan in nature. \nHumans colloquially refer to this as a 'city'.";

                 }
       else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "Wait, Pixeli.\nIs that a small human?";
                Char2name.text = "";
                Char2speech.text = "";

                 }

       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "Yes. Small humans are commonly referred to as children.";

                 }
      else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text = "I see. \nI need to act fast.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);

                }

// ENCOUNTER AFTER CHOICE #1
      else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Human1";
                Char3speech.text = "Is .. that dog talking?";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
          }
      else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "Yes, human. Heed me! I bring warnings!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
          }
      else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Human1";
                Char3speech.text = "Hey, Francesca, you see this?";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
          }
                else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Human2";
                Char4speech.text = "What the hell..?!";
                Char5name.text = "";
                Char5speech.text = "";
          }



                 else if (primeInt == 204){
                        Char1name.text = "";
                                  Char1speech.text = "";
                                  Char2name.text = "";
                                  Char2speech.text = "";
                                  Char3name.text = "Human1";
                                  Char3speech.text = "Aww .. talk again, doggy!";
                                  Char4name.text = "";
                                  Char4speech.text = "";
                                  Char5name.text = "";
                                  Char5speech.text = "";
          }
                 else if (primeInt == 205){
                                  Char1name.text = "";
                                  Char1speech.text = "";
                                  Char2name.text = "";
                                  Char2speech.text = "";
                                  Char3name.text = "";
                                  Char3speech.text = "";
                                  Char4name.text = "Human2";
                                  Char4speech.text = "Gary! Don't get too close; it might have rabies. ..";
                                  Char5name.text = "";
                                  Char5speech.text = "";
                                  Choice1a.SetActive(true);
                                  Choice1b.SetActive(true);
          }

    // Encounter after Choice 1b                                                                                                                     }

                else if (primeInt == 300){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text= "";
                         Char3speech.text = "";
                         Char4name.text = "Human2";
                         Char4speech.text = "Gary, it's making fun of me.";
                         Char5name.text = "";
                         Char5speech.text = "";
                         }

                else if (primeInt == 301){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Human1";
                        Char3speech.text = "You got a problem with my wife, mutt?";
                        Char4name.text = "";
                        Char4speech.text = "";
                        Char5name.text = "";
                        Char5speech.text = "";
                        }
                else if (primeInt == 302){
                        Char1name.text = "YOU";
                        Char1speech.text = "We all have a problem here! You humans most of all.\nYou are in grace danger!";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                        Char4name.text = "";
                        Char4speech.text = "";
                        Char5name.text = "";
                        Char5speech.text = "";
                    }
              else if (primeInt == 303){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                            Char3name.text = "";
                            Char3speech.text = "";
                            Char4name.text = "";
                            Char4speech.text = "";
                            Char5name.text = "Human3";
                            Char5speech.text = "You threatening us? How about getting a fist to the mouth?!";
                            nextButton.SetActive(false);
                            allowSpace = false;
                            NextScene4Button.SetActive(true);
                 }
 else if (primeInt == 400){
      Char1name.text = "YOU";
      Char1speech.text = "Hmph. .. You all refuse to listen.\nI will find someone else who will heed my warning.";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      Char5name.text = "";
      Char5speech.text = "";
                     }
else if (primeInt == 401){
      Char1name.text = "YOU";
      Char1speech.text = "You, other human. Heed me!";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      Char5name.text = "";
      Char5speech.text = "";
              }
else if (primeInt == 402){
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      Char5name.text = "Human3";
      Char5speech.text = "Aah! A talking dog! Should we .. call the police?";
             }
else if (primeInt == 403){
      Char1name.text = "YOU";
      Char1speech.text = "(The police?)\n(Are those the authority figures of this world?)";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      Char5name.text = "";
      Char5speech.text = "";
                          }
else if (primeInt == 404){
      Char1name.text = "YOU";
      Char1speech.text = "(Or .. could they become dangerous?)";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      Char5name.text = "";
      Char5speech.text = "";
      NextScene3Button.SetActive(true);
      NextScene4Button.SetActive(true);
                          }
else if (primeInt == 500){
      Char1name.text = "YOU";
      Char1speech.text = "(All these human buildings look the same!\n(Where do I go?!)";
      Char2name.text = "";
      Char2speech.text = "";
                          }
else if (primeInt == 501){
      Char1name.text = "YOU";
      Char1speech.text = "(Wait .. that's a small human in the distance!)\n(But .. should I go to it?)";
      Char2name.text = "";
      Char2speech.text = "";
      NextScene5Button.SetActive(true);
      NextScene6Button.SetActive(true);
      nextButton.SetActive(false);
                          }
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)

  public void Choice1aFunct(){
      Char1name.text = "YOU";
      Char1speech.text = "I am not subject to your paltry human diseases.";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      Char5name.text = "";
      Char5speech.text = "";
       primeInt = 299;
       Choice1a.SetActive(false);
       Choice1b.SetActive(false);
       nextButton.SetActive(true);
       allowSpace = true;
                 				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
       GameHandler.hasComm = true;
                         }
  public void Choice1bFunct(){
        Char1name.text = "YOU";
        Char1speech.text = "(The more the better. At least one of them has to believe me!)";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        Char4name.text = "";
        Char4speech.text = "";
        Char5name.text = "";
        Char5speech.text = "";
        primeInt = 399;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
                 				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasProof = true;
        GameHandler.hasProof = true;
                         }
    public void SceneChange1Funct(){
        SceneManager.LoadScene("Scene4");
      }
    public void SceneChange2Funct(){
      if (GameHandler.hasProof==true){
        NextScene2Button.SetActive(false);
      }
      ArtChar1.SetActive(true);
      ArtChar2.SetActive(true);
      ArtChar3.SetActive(true);
      ArtChar4.SetActive(true);
      NextScene1Button.SetActive(false);
      NextScene2Button.SetActive(false);
      nextButton.SetActive(true);
      allowSpace = true;
            Char1name.text = "YOU";
            Char1speech.text = "Humans! I came here with a warning.\nYou’re all in incredible danger!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
        primeInt=199;
      }
    public void SceneChange3Funct(){
      SceneManager.LoadScene("Scene10");
    }
    public void SceneChange4Funct(){
      ArtBG1.SetActive(false);
      ArtBG2.SetActive(true);
      ArtChar1.SetActive(false);
      ArtChar2.SetActive(false);
      ArtChar3.SetActive(false);
      ArtChar4.SetActive(false);
      NextScene4Button.SetActive(false);
      nextButton.SetActive(true);
      allowSpace = true;
          Char1name.text = "YOU";
          Char1speech.text = "(I have to run..!)";
          Char2name.text = "";
          Char2speech.text = "";
          Char3name.text = "";
          Char3speech.text = "";
          Char4name.text = "";
          Char4speech.text = "";
          Char5name.text = "";
          Char5speech.text = "";
        primeInt=499;
    }
    public void SceneChange5Funct(){
      SceneManager.LoadScene("End_BadEnd4");
    }
    public void SceneChange6Funct(){
      SceneManager.LoadScene("Scene4");
    }
    IEnumerator TypeText(Text target, string fullText){
                 float delay = 0.01f;
                 nextButton.SetActive(false);
                 allowSpace = false;
                 for (int i = 0; i < fullText.Length; i++){
                         string currentText = fullText.Substring(0,i);
                         target.text = currentText;
                         yield return new WaitForSeconds(delay);
     }
   }
 }

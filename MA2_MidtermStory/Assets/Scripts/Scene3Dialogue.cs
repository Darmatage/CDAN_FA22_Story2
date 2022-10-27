using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
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
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

      if(GameHandler.hasAi==true){
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
                // AudioSource.Play();
      }
        else if (primeInt == 2){
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(The amount of humans here..is overwhelming.\n(...)\n(The more the better I suppose.)";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text ="(Wait, is that .. a little human?)";
                Char1speech.text ="";
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

      }

       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "Pixeli, do you have any information about this place? \nHave you surveyed the area?";
                Char2name.text = "";
                Char2speech.text = "";
                         //gameHandler.AddPlayerStat(1);
                 }

       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "Yes: this area is urban and metropolitan in nature. \nHumans colloquially refer to this as a 'city'.";

                 }
       else if (primeInt == 102){
                Char1name.text = "YOU";
                Char1speech.text = "Wait, Pixeli. \nIs that a small human?";
                Char2name.text = "";
                Char2speech.text = "";

                 }
       else if (primeInt == 102){
                Char1name.text = "YOU";
                Char1speech.text = "Wait, Pixeli. \nIs that a small human?";
                Char2name.text = "";
                Char2speech.text = "";

                 }
       else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "Yes. Small humans are commonly referred to as children.";

                 }
      else if (primeInt == 104){
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
                         Char1name.text = "YOU";
                         Char1speech.text = "Hello, underdeveloped female human. I need your help.";
                         Char2name.text = "Matilda";
                         Char2speech.text = "Woah, a talking dog?/nHere, doggy doggy!";
                 }
      else if (primeInt == 201){
                         Char1name.text = "YOU";
                         Char1speech.text = "(This must be a common gesture among humans. I should cooperate with this specimen so things go smoothly)";
                         Char2name.text = "";
                         Char2speech.text = "My name is Matilda! How can I help?";
                         nextButton.SetActive(false);
                         allowSpace = false;
                         NextScene1Button.SetActive(true); //scene 2
                         }
                else if (primeInt == 202){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Matilda";
                        Char2speech.text ="They work in a big office where they beat bad guys and talk to people in neat suits always. They're the coolest!";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene1Button.SetActive(true); //scene 2

                                  }
                else if (primeInt == 203){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Matilda";
                        Char2speech.text = "Do you want a jelly sandwich, it's my favorite!";
                                   }
                else if (primeInt == 204){
                        Char1name.text = "YOU";
                        Char1speech.text = "Your reply is astonishingly unhelpful. What's this sand-wich you are shubbing into your mouth?";
                        Char2name.text = "Matilda";
                        Char2speech.text = "No, you nincompoop. Sandwich is a sandwich. Here. Try some.";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene1Button.SetActive(true); //scene 2
                                           }

                else if (primeInt == 205){
                        Char1name.text = "";
                                  Char1speech.text = " ";
                                  Char2name.text = "Matilda";
                                  Char2speech.text = "Do they not have sandwiches on Gi-niper-a?";
                                                              }
                 else if (primeInt == 206){
                                  Char1name.text = "YOU";
                                  Char1speech.text = "How..just how do you know that? Have humans discovered my planet already?";
                                  Char2name.text = "Matilda";
                                  Char2speech.text = "I don't know. I just heard it from your brain.";
                                  nextButton.SetActive(false);
                                  allowSpace = false;
                                  NextScene1Button.SetActive(true); //scene 2
                                }
                  else if (primeInt == 207){
                                    Char1name.text = "YOU";
                                                  Char1speech.text = "But I haven't said anything about my home planet. How could you know?";
                                                  Char2name.text = "Matilda";
                                                  Char2speech.text = "I didn't hear your mouth saying it. I heard from your head.";
                                                                                         }
                  else if (primeInt == 208){
                                                  Char1name.text = "YOU";
                                                  Char1speech.text = "A psychic? I've never heard of it. Your human species shouldn't have developed enough to possess that ability.";
                                                  Char2name.text = "Matilda";
                                                  Char2speech.text = "People's heads have always talked to me so your friends are coming too? But they're coming....to fight?";
                                                  nextButton.SetActive(false);
                                                  allowSpace = false;
                                                  NextScene1Button.SetActive(true); //scene 2
                                                                                                 }
                  else if (primeInt == 209){
                                                  Char1name.text = "YOU";
                                                  Char1speech.text = "Right! Your planet is in danger. I need to talk to the leader of this planet.";
                                                  Char2name.text = "Matilda";
                                                  Char2speech.text = "Off to go see Dad and Dad then!";
                                            }
                  else if (primeInt == 210){
                                                    Char1name.text = "";
                                                    Char1speech.text = "";
                                                    Char2name.text = "";
                                                    Char2speech.text = "";
                                                    nextButton.SetActive(false);
                                                    allowSpace = false;
                                                    NextScene1Button.SetActive(true); //scene 2

                                }
    // Encounter after Choice 1b                                                                                                                     }
                else if (primeInt == 300){
                         Char1name.text = "";
                         Char1speech.text = "<YOU approaches a group of humans>";
                         Char2name.text = "";
                         Char2speech.text = "";
                         }

                else if (primeInt == 301){
                         Char1name.text = "YOU";
                         Char1speech.text = "Hello, fellow citizens of Earth! I came from a planet that's far away to tell you're in danger-";
                         Char2name.text = "Human1";
                         Char2speech.text = "G.e.t. o.u.t! It's a talking dog!";
                         nextButton.SetActive(false);
                         allowSpace = false;
                         NextScene1Button.SetActive(true); //scene 2
                         }

                else if (primeInt == 302){
                        Char1name.text = "Human2";
                        Char1speech.text = "What the hell!";
                        Char2name.text = "Human3";
                        Char2speech.text = "I'm calling the freaking police!";
                          }
                else if (primeInt == 303){
                                  Char1name.text = "YOU";
                                  Char1speech.text = "(The Police? Are those the authority figures in this world? Or could they be dangerous?)";
                                  Char2name.text = "";
                                  Char2speech.text = "";
                                  nextButton.SetActive(false);
                                  allowSpace = false;
                                  NextScene1Button.SetActive(true); // scene 2
                          }
                 }
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
  public void Choice1aFunct(){
       Char1name.text = "YOU";
       Char1speech.text = "(This small human has some comforting ambience.. I wonder why?)";
       Char2name.text = "";
       Char2speech.text = "";
       primeInt = 199;
       Choice1a.SetActive(false);
       Choice1b.SetActive(false);
       nextButton.SetActive(true);
       allowSpace = true;
                 				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
       GameHandler.hasComm = true;
                         }
  public void Choice1bFunct(){
        Char1name.text = "YOU";
        Char1speech.text = "The more the better. At least one of them has to believe me!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
                 				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasProof = true;
        GameHandler.hasProof = true;
                         }
    public void SceneChange1(){
        SceneManager.LoadScene("Scene4");
      }
                         //public void SceneChange2(){
                         //        SceneManager.LoadScene("Scene2b");
                         //}
 }

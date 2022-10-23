using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour {
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
       //public GameHandler gameHandler;
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
                         Choice1a.SetActive(true);
                         Choice1b.SetActive(true);
          }

// ENCOUNTER AFTER CHOICE #1
          else if (primeInt == 200){
                         Char1name.text = "YOU";
                         Char1speech.text = "Hello, underdeveloped female human. I need your help.";
                         Char2name.text = "";
                         Char2speech.text = "";
          }
          else if (primeInt == 201){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "Woah, a talking dog? Here, doggy doggy!";
                         nextButton.SetActive(false);
                         allowSpace = false;
                         NextScene1Button.SetActive(true);
          }
          else if (primeInt == 202){
                   Char1name.text = "YOU";
                   Char1speech.text = "(This must be a common gesture among humans. I should cooperate with this specimen so things go smoothly)";
                   Char2name.text = "";
                   Char2speech.text = "";
                 } 



            else if (primeInt == 203){
                                  Char1name.text = "";
                                  Char1speech.text = "";
                                  Char2name.text = "Matilda";
                                  Char2speech.text = "Do you want a jelly sandwich, it's my favorite!";
                                   }
                else if (primeInt == 204){
                                  Char1name.text = "YOU";
                                  Char1speech.text = "What's this sand-wich you are shubbing into your mouth?";
                                  Char2name.text = "";
                                  Char2speech.text = "";
                                  nextButton.SetActive(false);
                                  allowSpace = false;
                                  NextScene1Button.SetActive(true);
                }
                else if (primeInt == 205){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "No, you nincompoop. Sandwich is a sandwich./nDo they not have sandwiches on Gi-niper-a?";
                         nextButton.SetActive(false);
                         allowSpace = false;
                         NextScene1Button.SetActive(true);
              }
              else if (primeInt == 206){
                       Char1name.text = "YOU";
                       Char1speech.text = "How..just how do you know that? Have humans discovered my planet already?";
                       Char2name.text = "";
                       Char2speech.text = "";
                       }

              else if (primeInt == 207){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "Matilda";
                       Char2speech.text = "I don't know. I just heard it from your brain.";
                       nextButton.SetActive(false);
                       allowSpace = false;
                       NextScene1Button.SetActive(true);
                       }

                else if (primeInt == 208){
                                  Char1name.text = "YOU";
                                  Char1speech.text = "A psychic? I've never heard of it. Your human species shouldn't have developed enough to possess that ability.";
                                  Char2name.text = "";
                                  Char2speech.text = "";
                                                              }
                 else if (primeInt == 209){
                                  Char1name.text = "";
                                  Char1speech.text = "";
                                  Char2name.text = "Matilda";
                                  Char2speech.text = "People's heads have always talked to me so your friends are coming too? But they're coming....to fight?";
                                  nextButton.SetActive(false);
                                  allowSpace = false;
                                  NextScene1Button.SetActive(true);
                                }
                  else if (primeInt == 210){
                                    Char1name.text = "YOU";
                                                  Char1speech.text = "Right! Your planet is in danger. I need to talk to the leader of this planet.";
                                                  Char2name.text = "";
                                                  Char2speech.text = "";
                                                                                         }
          else if (primeInt == 211){
                                                  Char1name.text = "";
                                                  Char1speech.text = "";
                                                  Char2name.text = "Matilda";
                                                  Char2speech.text = "We should go see my dads then! They are pretty rads. Off we go then!";
                                                  nextButton.SetActive(false);
                                                  allowSpace = false;
                                                  NextScene1Button.SetActive(true);
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
                         Char2name.text = "";
                         Char2speech.text = "";
                         nextButton.SetActive(false);
                         allowSpace = false;
                         NextScene1Button.SetActive(true);
             }
             else if (primeInt == 302){
                                             Char1name.text = "";
                                             Char1speech.text = "";
                                             Char2name.text = "Human1";
                                             Char2speech.text = "No way! It's a talking dog!";
                                       }

             else if (primeInt == 303){
                                               Char1name.text = "Human2";
                                               Char1speech.text = "Someone call me cops now!";
                                               Char2name.text = "";
                                               Char2speech.text = "";
                                               nextButton.SetActive(false);
                                               allowSpace = false;
                                               NextScene1Button.SetActive(true);
                                          }




                else if (primeInt == 304){
                                  Char1name.text = "";
                                  Char1speech.text = "";
                                  Char2name.text = "Human3";
                                  Char2speech.text = "I'm calling the freaking police!";
                          }
                else if (primeInt == 305){
                                  Char1name.text = "YOU";
                                  Char1speech.text = "(The Police? Are those the authority figures in this world? Or could they be dangerous?)";
                                  Char2name.text = "";
                                  Char2speech.text = "";
                                  nextButton.SetActive(false);
                                  allowSpace = false;
                                  NextScene1Button.SetActive(true);
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
                         //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasAi = true;
                         GameHandler.hasAi = true;
                         }


        public void SceneChange1(){
                SceneManager.LoadScene("Scene3b");
        }

        //public void SceneChange2(){
        //        SceneManager.LoadScene("Scene2b");
        //}
        }

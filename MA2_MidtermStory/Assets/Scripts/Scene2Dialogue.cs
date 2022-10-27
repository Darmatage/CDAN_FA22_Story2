using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1;  // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
        public static bool hasComm=true;
        public static bool hasAi=true;
        public static bool hasProof=true;


void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){ // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();

              }
            }
          }

//Story Units:
public void talking(){  // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(Those buildings .. )\n(They look like human capacity units.)";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "You";
                Char1speech.text = "(Wait .. is that another quadruped?)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         DialogueDisplay.SetActive(false);
         ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
         DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cat";
                Char2speech.text = "(Meow.)";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(Ah! It speaks.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "(...)";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;

				//show button based on Statc Variable
				if (GameHandler.hasProof == true){
					Choice1a.SetActive(true); // bark
					Choice1b.SetActive(false);
				}
				else if ((GameHandler.hasComm == true)||(GameHandler.hasAi == true)){
					Choice1a.SetActive(false);
					Choice1b.SetActive(true); // Attempt communication (only if player has AI or Comm)
				}
				else {
					Debug.Log("no static variable is true. No button for you");
					}
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "Bark, bark! BARK!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
      }
       else if (primeInt == 101){ 				// cat runs away
                DialogueDisplay.SetActive(false);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cat";
                Char2speech.text = "(Hiss!)";
      }
       else if (primeInt == 102){
                DialogueDisplay.SetActive(true);
                ArtChar1b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "(Ugh, it seems this creature cannot understand my .. dog tongue.)";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt == 104){
                 Char1name.text = "YOU";
                 Char1speech.text = "(Why did I expect anything different?)";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
      else if (primeInt == 105){
                 Char1name.text = "YOU";
                 Char1speech.text = "(If this specimen doesn't understand me, I don't know if the humans will.) \nI('ll just have to improvise.)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 allowSpace=false;
                 nextButton.SetActive(false);
                 NextScene1Button.SetActive(true);
                 NextScene2Button.SetActive(true);
      }

       else if (primeInt == 200){
                Char1name.text = "YOU";
                Char1speech.text = "G-- \n...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace=true;
        }
       else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "Greetings, creature.";
                Char2name.text = "";
                Char2speech.text = "";
        }
      else if (primeInt == 202){ 			// cat head tilt
                DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cat";
                Char2speech.text = " .. Meow?";
         }
       else if (primeInt == 203){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(Wow, I .. really sound like a human! \nIt doesn't even sound like .. well me!)";
                Char2name.text = "";
                Char2speech.text = "";
         }
        else if (primeInt == 204){
                Char1name.text = "YOU";
                Char1speech.text = "I am .. here to warn you. \nYou are .. in imminent danger!";
                Char2name.text = "";
                Char2speech.text = "";
         }
        else if (primeInt == 205){ // cat runs away
          ArtChar1a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "No, wait! This is very important. .. ";
                Char2name.text = "";
                Char2speech.text = "";
         }
        else if (primeInt == 206){
                Char1name.text = "YOU";
                Char1speech.text = "(Is this how humans react to dire situationss?) \n (By running away..?)";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 207){
                  Char1name.text = "YOU";
                  Char1speech.text = "(That won't solve anything. \nI'll find a way.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  nextButton.SetActive(false);
                  NextScene1Button.SetActive(true);
                  NextScene2Button.SetActive(true);
        }

      else if (primeInt == 300){
                 Char1name.text = "YOU";
                 Char1speech.text = "Bark! \n (I hope Pixeli's translation function is working. .. )";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 nextButton.SetActive(true);
                 allowSpace = true;
         }


	 else if (primeInt == 301){
              ArtChar1a.SetActive(false);
              ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Cat";
                 Char2speech.text = "Hisss!";
                 Char3name.text = "";
                 Char3speech.text = "";
                 nextButton.SetActive(true);
                 allowSpace = true;
         }
      else if (primeInt == 302){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "Pixeli";
                 Char3speech.text = "Don’t fret, creature. We mean no harm.";
         }
      else if (primeInt == 303){
           ArtChar1b.SetActive(false);
           ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Cat";
                 Char2speech.text = "...";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
      else if (primeInt == 305){
                 Char1name.text = "YOU";
                 Char1speech.text = "(Thank the stars.)\n... Bark, bark!";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
       else if (primeInt == 306){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Pixeli";
                  Char3speech.text = "Indeed, we are life forms, intent on saving your spieces!";
         }
		        else if (primeInt == 307){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Pixeli";
                  Char3speech.text = "He says: ‘Your planet is in imminent danger.";
         }
		       else if (primeInt == 308){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Cat";
                 Char2speech.text = "...";
				         Char3name.text = "";
                 Char3speech.text = "";
      }
            else if (primeInt == 309){
                Char1name.text = "YOU";
                Char1speech.text = "... Bark?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
     }
  }


// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){ //bark
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
  }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "(This is not a human... but it is worth a shot.)";
                Char2name.text = "";
                Char2speech.text = "";
				if (GameHandler.hasComm == true){primeInt = 199;}
				  else if (GameHandler.hasAi == true){primeInt = 299;}

                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

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


        public void SceneChange1(){
               SceneManager.LoadScene("Scene3"); //city
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5"); //suburbs
        }
     }

   // Let's assume that GameHandler.hasProof has the value we set it to at the end of scene 1
    // public void scenefunc(){
       // Direct the player to the line 199 as default
       //primeInt = 199;

       // if the player does not have proof (aka either has Comm or has AI)
       //if (!(GameHandler.hasProof)){
         /* show option b */

         //if (GameHandler.hasAi){
           // Direct the player to line 299 if hasAI = false then primeInt stays 299
           //primeInt=299;
         //}
       //}

       /* show option a */
       // Other vars
       //Choice1a.SetActive(false);
       //Choice1b.SetActive(false);
       //nextButton.SetActive(true);
       //allowSpace = true;
     //}

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
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; // cat off in distance, appearing on screen
        public GameObject ArtChar1b; // cat looking up
        public GameObject ArtChar1c; // closeup of cat, (alien approaches)
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
        public static bool hasComm=false;
        public static bool hasAi=false;
        public static bool hasProof=false;


void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
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
                 if (hasComm==true){
                     Choice1a.SetActive(false);
                 if (hasAi==true){
                    Choice1a.SetActive(false);
                if (hasProof==true){
                    Choice1b.SetActive(false);
              }
            }
          }
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
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct(), only if player has AI or Comm
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "(Bark, bark!)";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
      }
       else if (primeInt == 101){ // cat runs away
                DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt == 102){
                DialogueDisplay.SetActive(true);
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
      else if (primeInt == 202){ // cat head tilt
                DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
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
                Char1speech.text = "I am .. here to warn you. \nIs .. danger soon!";
                Char2name.text = "";
                Char2speech.text = "";
         }
        else if (primeInt == 205){ // cat runs away
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
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "You";
                 Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 NextScene2Button.SetActive(true);
         }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;


    }
        public void Choice1bFunct(){
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
            if (hasComm==true){
                primeInt = 199;
           if (hasAi==true){
                primeInt=299;
          }
        }
      }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
}

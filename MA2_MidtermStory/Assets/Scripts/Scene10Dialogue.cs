using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10Dialogue : MonoBehaviour {
        public int primeInt = 1;  // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        public Text Char5name;
        public Text Char5speech;
        public Text Char6name;
        public Text Char6speech;
        public Text Char7name;
        public Text Char7speech;
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
               if (GameHandler.hasComm == true){primeInt = 199;}
               if(GameHandler.hasAi == true){primeInt = 199;}
               else if (GameHandler.hasProof == true){primeInt = 299;}
}

//Story Units:
public void talking(){  // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "POTUS";
                Char2speech.text = "Agent Chris and Agent Evans. I believe you have the foreign being with you.";
				        Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";

        }
       else if (primeInt ==3){
         DialogueDisplay.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "";
         Char2speech.text = "";
         Char3name.text = "Chris";
         Char3speech.text = "Yes, sir. A, meet Presient Smithwell. President Smithwell, this is Am the foreign alien who brings valuable intel.";
         Char4name.text = "";
         Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         DialogueDisplay.SetActive(false);
         ArtChar1a.SetActive(true);
         DialogueDisplay.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "";
         Char2speech.text = "";
         Char3name.text = "";
         Char3speech.text = "";
         Char4name.text = "";
         Char4speech.text = "";
         Char5name.text = "GS";
         Char5speech.text = "Hmph! We'll be the judge of that, Agent Chris. Housing this foreign thins and arranging this meeting anyway? This thing could be a spy!";
        }
       else if (primeInt == 5){
         DialogueDisplay.SetActive(true);
         DialogueDisplay.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "POTUS";
         Char2speech.text = "Stand down. It was not your choice to make back whether I should meet this alien or not. IS that understood?";
         Char3name.text = "";
         Char3speech.text = "";
         Char4name.text = "";
         Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5){
          DialogueDisplay.SetActive(true);
          DialogueDisplay.SetActive(true);
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "";
          Char2speech.text = "";
          Char3name.text = "";
          Char3speech.text = "";
          Char4name.text = "GS";
          Char4speech.text = "Yes, sir!";
                 //gameHandler.AddPlayerStat(1);
         }
         else if (primeInt == 5){
           DialogueDisplay.SetActive(true);
           DialogueDisplay.SetActive(true);
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "POTUS";
           Char2speech.text = "NASA's satellites and our probes in space sent back data of an unknown surge of energy from far out of space. This energy have been increasing in strength since then. We've even begun receiving images of what seems to be small tears near the ozone layer.";
           Char3name.text = "";
           Char3speech.text = "";
           Char4name.text = "";
           Char4speech.text = "";
                  //gameHandler.AddPlayerStat(1);
          }
          else if (primeInt == 5){
            DialogueDisplay.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Those surges of energy are the result of my people, the Giniperians, sending trans-gravitational pulses near Earth in order to rip open a portal./nI was able to ride it to Earth through it wrecked my ship due to the instability of the portal.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
                   //gameHandler.AddPlayerStat(1);
           }
           else if (primeInt == 5){
             DialogueDisplay.SetActive(true);
             DialogueDisplay.SetActive(true);
             Char1name.text = "YOU";
             Char1speech.text = "However, once enough energy has been gathered to stabilize the wormhole, within hours, by my calculations, the portal should be completed and the full might of Giniperia will come through to raze this land.";
             Char2name.text = "";
             Char2speech.text = "";
             Char3name.text = "";
             Char3speech.text = "";
             Char4name.text = "";
             Char4speech.text = "";
                    //gameHandler.AddPlayerStat(1);
            }
            else if (primeInt == 5){
              DialogueDisplay.SetActive(true);
              DialogueDisplay.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "";
              Char4speech.text = "";
              Char5name.text = "GS";
              Char5speech.text = "Then we should be preparing our defenses now! We need to notify every country and mobilize our army! The Navy, Homeland Security, everything sir!";
                     //gameHandler.AddPlayerStat(1);
             }
             else if (primeInt == 5){
               DialogueDisplay.SetActive(true);
               DialogueDisplay.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "";
               Char3speech.text = "";
               Char4name.text = "Evans";
               Char4speech.text = "President Potus, with all due respect, do you really think trying to shore up our defenses is the best option? We would've needed days to prepare the army./nIn only a matter of time, the invasion will start.";
               Char5name.text = "";
               Char5speech.text = "";
                      //gameHandler.AddPlayerStat(1);
              }
              else if (primeInt == 5){
                DialogueDisplay.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "GS";
                Char5speech.text = "They will be forced to face reality when they see the truth with their own eyes. Then they weill know that we were right!";
                       //gameHandler.AddPlayerStat(1);
               }
               else if (primeInt == 5){
                 DialogueDisplay.SetActive(true);
                 DialogueDisplay.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "Chris";
                 Char3speech.text = "What good will that do us then? It doesn't matter if we were right or wrong./nThe invasion will take everyone and the chain of command around the world will be in shambles.";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";
                        //gameHandler.AddPlayerStat(1);
                }
                else if (primeInt == 5){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "YOU";
                  Char1speech.text = "And even if you humans miraculously gathered the army, you would still stand no chance to the Giniperian's fleet. Your options are few, President Smith.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";

                 }

                 else if (primeInt == 5){
                   DialogueDisplay.SetActive(true);
                   DialogueDisplay.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "POTUS";
                   Char2speech.text = "What do you suggest we do then? You alone have the best knowledge about this inevitable disaster.";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   Char5name.text = "";
                   Char5speech.text = "";
                   // Turn off "Next" button, turn on "Choice" buttons
                   nextButton.SetActive(false);
                   allowSpace = false;
                   Choice1a.SetActive(true); // function Choice1aFunct()
                   Choice1b.SetActive(true); // function Choice1bFunct()
}

        //after choice 1:
                else if (primeInt == 500){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "YOU";
                  Char1speech.text = "This is a slim possibility but you can surrender. Let's bet on the possibility that you have a high chance of surviving this invasion/nor you could face certain death.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";
                         //gameHandler.AddPlayerStat(1);
                 }
                 else if (primeInt == 5){
                   DialogueDisplay.SetActive(true);
                   DialogueDisplay.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "POTUS";
                   Char2speech.text = "Ok, say we do surrender. What happens to us then?";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   Char5name.text = "";
                   Char5speech.text = "";
                          //gameHandler.AddPlayerStat(1);
                  }
                  else if (primeInt == 5){
                    DialogueDisplay.SetActive(true);
                    DialogueDisplay.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "Most likely, the occupation of Earth by the Ginniperians. They will set up camps and extract the planet's /norganic matter. The more cooperative, the faster they will leave Earth and you will be able to live in a peaceful co-existence.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
                    Char4name.text = "";
                    Char4speech.text = "";
                    Char5name.text = "";
                    Char5speech.text = "";
                           //gameHandler.AddPlayerStat(1);
                   }
                   else if (primeInt == 5){
                     DialogueDisplay.SetActive(true);
                     DialogueDisplay.SetActive(true);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "POTUS";
                     Char2speech.text = "You suggest my people to be enslaved? forced to give up all resources to the army invading us? /n They will leave behind a hust of our world.";
                     Char3name.text = "";
                     Char3speech.text = "";
                     Char4name.text = "";
                     Char4speech.text = "";
                     Char5name.text = "";
                     Char5speech.text = "";
                            //gameHandler.AddPlayerStat(1);


                }
                else if (primeInt == 5){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "But you will die! If you surrender, your race will be able to live on!";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";
                         //gameHandler.AddPlayerStat(1);
                 }
                 else if (primeInt == 5){
                   DialogueDisplay.SetActive(true);
                   DialogueDisplay.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "POTUS";
                   Char2speech.text = "It seems I've mistaken my judgement in you. Perhaps this is a foreign concept to you but to us, living means much more than just surviving./nI cannot trust the judgement of someone who can suggest such astrocity and calls it peace.";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   Char5name.text = "";
                   Char5speech.text = "";
                          //gameHandler.AddPlayerStat(1);
                  }
                  else if (primeInt == 5){
                    DialogueDisplay.SetActive(true);
                    DialogueDisplay.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "POTUS";
                    Char2speech.text = "Alien, you are mistaken. This si the land of the free and if we die trying to protect that freedome, then so be it. Mobilize the army, General Smithwell!";
                    Char3name.text = "";
                    Char3speech.text = "";
                    Char4name.text = "";
                    Char4speech.text = "";
                    Char5name.text = "";
                    Char5speech.text = "";
                           //gameHandler.AddPlayerStat(1);
                   }
                   //Go to the bad ending 3: THE ANNIHILATION

               else if (primeInt == 600){
                 DialogueDisplay.SetActive(true);
                 DialogueDisplay.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "POTUS";
                 Char2speech.text = "That of course is the optimal option. What happens if one side is unable to uphold their promise?/nWhat if we are unable to provide the Giniperians the quantity of resources they demand?";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";
                        //gameHandler.AddPlayerStat(1);
                }
                else if (primeInt == 600){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "YOU";
                  Char1speech.text = "I think you misunderstood something. You seem to be protecting your own flaws into this. We do not lie. These aren't just pretty promises./nPlease refrain from such actions. It is quite unsightly.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";
                         //gameHandler.AddPlayerStat(1);
                 }
                 else if (primeInt == 600){
                   DialogueDisplay.SetActive(true);
                   DialogueDisplay.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "POTUS";
                   Char2speech.text = "Enough. ";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   Char5name.text = "";
                   Char5speech.text = "";
                          //gameHandler.AddPlayerStat(1);
                }
            }








                //FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
                         public void Choice1aFunct(){
                                Char1name.text = "YOU";
                                Char1speech.text = "The humans have no way of winning this battle! Let's surrender.";
                                Char2name.text = "";
                                Char2speech.text = "";
                                primeInt = 499;
                                Choice1a.SetActive(false);
                                Choice1b.SetActive(false);
                                nextButton.SetActive(true);
                                allowSpace = true;
                        //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
                        }
                        public void Choice1bFunct(){
                                Char1name.text = "YOU";
                                Char1speech.text = "You could negotiate a deal with the Giniperians. I can help you send a dialogue to open communications. What they seek is the organic matter of this Earth./nI believe there are better ways to go about obtaining said materials and I know/nthat there are others who believe in more peaceful solution.";
                                Char2name.text = "";
                                Char2speech.text = "";
                                primeInt = 599;
                                Choice1a.SetActive(false);
                                Choice1b.SetActive(false);
                                nextButton.SetActive(true);
                                allowSpace = true;
                                //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
                                //GameHandler.hasAi = true;
                        }
                    }

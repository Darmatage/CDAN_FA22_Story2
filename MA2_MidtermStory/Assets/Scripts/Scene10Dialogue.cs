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
         public GameObject Choice1c;
          public GameObject Choice1d;
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
               if (GameHandler.hasComm == true){primeInt = 1;}
               if(GameHandler.hasAi == true){primeInt = 1;}
               else if (GameHandler.hasProof == true){primeInt = 900;}
}

//With communication:
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
        else if (primeInt == 6){
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
         else if (primeInt == 7){
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
          else if (primeInt == 8){
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
           else if (primeInt == 9){
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
            else if (primeInt == 10){
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
             else if (primeInt == 11){
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
              else if (primeInt == 12){
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
               else if (primeInt == 13){
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
                else if (primeInt == 14){
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
                         //gameHandler.AddPlayerStat(1);
                 }
                 else if (primeInt == 15){
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
                 else if (primeInt == 501){
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
                  else if (primeInt == 502){
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
                   else if (primeInt == 503){
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
                else if (primeInt == 504){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "YOU";
                  Char1speech.text = "But you will die! If you surrender, your race will be able to live on!";
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
                 else if (primeInt == 505){
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
                  else if (primeInt == 506){
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
                else if (primeInt == 601){
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
                 else if (primeInt == 602){
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
                   // Turn off "Next" button, turn on "Choice" buttons
                   nextButton.SetActive(false);
                   allowSpace = false;
                   Choice1c.SetActive(true); // function Choice1aFunct()
                   Choice1d.SetActive(true); // function Choice1bFunct()
           }






        //Encounter after choice c(Apologize)
                  else if (primeInt == 700){
                    DialogueDisplay.SetActive(true);
                    DialogueDisplay.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "I apologize sincerely for my misconduct. I simply wish that we can get along and forge/na better future for both of our people. I don’t mean to insult humans.  I simply state what I believe to be true.";
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
                   else if (primeInt == 504){
                     DialogueDisplay.SetActive(true);
                     DialogueDisplay.SetActive(true);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "POTUS";
                     Char2speech.text = "Thank you, Alien. General Stillwell?";
                     Char3name.text = "";
                     Char3speech.text = "";
                     Char4name.text = "";
                     Char4speech.text = "";
                     Char5name.text = "";
                     Char5speech.text = "";

                    }
                    else if (primeInt == 504){
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
                      Char5speech.text = "I'm sorry for being an asshole.";

                     }
                     else if (primeInt == 504){
                       DialogueDisplay.SetActive(true);
                       DialogueDisplay.SetActive(true);
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "POTUS";
                       Char2speech.text = "Eloquent. Now let's get proceed.";
                       Char3name.text = "";
                       Char3speech.text = "";
                       Char4name.text = "";
                       Char4speech.text = "";
                       Char5name.text = "";
                       Char5speech.text = "";

                      }


       //Encounter after choice d (Refuse):
       else if (primeInt == 800){
         DialogueDisplay.SetActive(true);
         DialogueDisplay.SetActive(true);
         Char1name.text = "YOU";
         Char1speech.text = "With all due respect here, President Smith, I see no reason for me to confess/nto an apology. I simply stated what is true and advised my peer to better conduct himself in the future.";
         Char2name.text = "";
         Char2speech.text = "";
         Char3name.text = "";
         Char3speech.text = "";
         Char4name.text = "";
         Char4speech.text = "";
         Char5name.text = "";
         Char5speech.text = "";

        }
        else if (primeInt == 504){
          DialogueDisplay.SetActive(true);
          DialogueDisplay.SetActive(true);
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "POTUS";
          Char2speech.text = "Okay, enough. It seems this tangent will only result in more conflict. I just request that you both/ndo not lose sight of the bigger picture among your squabbling.";
          Char3name.text = "";
          Char3speech.text = "";
          Char4name.text = "";
          Char4speech.text = "";
          Char5name.text = "";
          Char5speech.text = "";

         }
         else if (primeInt == 504){
           DialogueDisplay.SetActive(true);
           DialogueDisplay.SetActive(true);
           Char1name.text = "YOU";
           Char1speech.text = "...";
           Char2name.text = "";
           Char2speech.text = "";
           Char3name.text = "";
           Char3speech.text = "";
           Char4name.text = "";
           Char4speech.text = "";
           Char5name.text = "";
           Char5speech.text = "";

          }
          else if (primeInt == 504){
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
            Char5speech.text = "...";

           }
           else if (primeInt == 504){
             DialogueDisplay.SetActive(true);
             DialogueDisplay.SetActive(true);
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "POTUS";
             Char2speech.text = "So what were you saying, Alien?";
             Char3name.text = "";
             Char3speech.text = "";
             Char4name.text = "";
             Char4speech.text = "";
             Char5name.text = "";
             Char5speech.text = "";

            }
            else if (primeInt == 504){
              DialogueDisplay.SetActive(true);
              DialogueDisplay.SetActive(true);
              Char1name.text = "YOU";
              Char1speech.text = "Uh, yes, so I propose that you humans will write up a list of demands that I wlll/nbring back to my people and set up an formal meeting in which we can discuss this. I have confidence that the Giniperians will be reasonable and accept terms that aren’t outrageous";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
              Char4name.text = "";
              Char4speech.text = "";
              Char5name.text = "";
              Char5speech.text = "";

             }
             else if (primeInt == 504){
               DialogueDisplay.SetActive(true);
               DialogueDisplay.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "POTUS";
               Char2speech.text = "Do you think they would accept sharing their technology?";
               Char3name.text = "";
               Char3speech.text = "";
               Char4name.text = "";
               Char4speech.text = "";
               Char5name.text = "";
               Char5speech.text = "";

              }
              else if (primeInt == 504){
                DialogueDisplay.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "That depends. What do you plan on doing with said technology?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";

               }
               else if (primeInt == 504){
                 DialogueDisplay.SetActive(true);
                 DialogueDisplay.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "POTUS";
                 Char2speech.text = "Right now, we’re very much the underdog. The Giniperians could, and I’m not saying they will, break our agreement at any time without/nsignificant repercussions. I believe by sharing your tech, we can reach a better relationship and understanding.";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";

                }
                else if (primeInt == 504){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "YOU";
                  Char1speech.text = "That is a very valid point. I believe they will accept that clause. So does this mean you accept this proposal?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";

                 }
                 else if (primeInt == 504){
                   DialogueDisplay.SetActive(true);
                   DialogueDisplay.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "POTUS";
                   Char2speech.text = "It’s still not a final decision yet but for the time being, the USA supports the idea of negotiating with the Giniperians./nI’ll just have to confer with the rest of the world as well. But I’m confident they can see the desperation of our situation and understand this is the most logical course.";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   Char5name.text = "";
                   Char5speech.text = "";

                  }
                  else if (primeInt == 504){
                    DialogueDisplay.SetActive(true);
                    DialogueDisplay.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "I'm glad you think so.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
                    Char4name.text = "";
                    Char4speech.text = "";
                    Char5name.text = "";
                    Char5speech.text = "";

                   }
                   else if (primeInt == 504){
                     DialogueDisplay.SetActive(true);
                     DialogueDisplay.SetActive(true);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "POTUS";
                     Char2speech.text = "On behalf of this planet, we thank you for your invaluable assistance. I truly hope this can lead to a brighter future for both of our people.";
                     Char3name.text = "";
                     Char3speech.text = "";
                     Char4name.text = "";
                     Char4speech.text = "";
                     Char5name.text = "";
                     Char5speech.text = "";

                    }
                    else if (primeInt == 504){
                      DialogueDisplay.SetActive(true);
                      DialogueDisplay.SetActive(true);
                      Char1name.text = "YOU";
                      Char1speech.text = "Likewise, President.";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "";
                      Char4speech.text = "";
                      Char5name.text = "";
                      Char5speech.text = "";

                     }
                     else if (primeInt == 504){
                       DialogueDisplay.SetActive(true);
                       DialogueDisplay.SetActive(true);
                       Char1name.text = "";
                       Char1speech.text = "(President leaves along with General Stillwell)";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
                       Char4name.text = "";
                       Char4speech.text = "";
                       Char5name.text = "";
                       Char5speech.text = "";

                      }
                      else if (primeInt == 504){
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
                        Char5name.text = "";
                        Char5speech.text = "";
                        Char6name.text = "MATILDA";
                        Char6speech.text = "You did it! You saved the Earth!";

                       }
                       else if (primeInt == 504){
                         DialogueDisplay.SetActive(true);
                         DialogueDisplay.SetActive(true);
                         Char1name.text = "YOU";
                         Char1speech.text = "I wouldn’t be quite so hasty. The President still have to confer with the other nations as well.";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
                         Char4name.text = "";
                         Char4speech.text = "";
                         Char5name.text = "";
                         Char5speech.text = "";
                         Char6name.text = "";
                         Char6speech.text = "";

                        }
                        else if (primeInt == 504){
                          DialogueDisplay.SetActive(true);
                          DialogueDisplay.SetActive(true);
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "";
                          Char2speech.text = "";
                          Char3name.text = "";
                          Char3speech.text = "";
                          Char4name.text = "EVANS";
                          Char4speech.text = "Oh that’s just a formality. Choosing between certain death and a chance to progress our technology infinitely faster? That’s kinda a no brainer.";
                          Char5name.text = "";
                          Char5speech.text = "";
                          Char6name.text = "";
                          Char6speech.text = "";

                         }
                         else if (primeInt == 504){
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
                           Char5name.text = "";
                           Char5speech.text = "";
                           Char6name.text = "MATILDA";
                           Char6speech.text = "Will this mean you have to go back to Giniperia?";

                          }
                          else if (primeInt == 504){
                            DialogueDisplay.SetActive(true);
                            DialogueDisplay.SetActive(true);
                            Char1name.text = "YOU";
                            Char1speech.text = "Originally that was my intention but I’ve grown quite fond of this planet. It’s certainly a lot nicer than the dullness of my home. ";
                            Char2name.text = "";
                            Char2speech.text = "";
                            Char3name.text = "";
                            Char3speech.text = "";
                            Char4name.text = "";
                            Char4speech.text = "";
                            Char5name.text = "";
                            Char5speech.text = "";
                            Char6name.text = "";
                            Char6speech.text = "";

                           }
                           else if (primeInt == 504){
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
                             Char5name.text = "";
                             Char5speech.text = "";
                             Char6name.text = "MATILDA";
                             Char6speech.text = "You have to stay then! I get to tell people I have a alien friend and they can’t even tell me lying! ";

                            }
                            else if (primeInt == 504){
                              DialogueDisplay.SetActive(true);
                              DialogueDisplay.SetActive(true);
                              Char1name.text = "YOU";
                              Char1speech.text = "Well, you got me there. How could I resist such an offer?";
                              Char2name.text = "";
                              Char2speech.text = "";
                              Char3name.text = "";
                              Char3speech.text = "";
                              Char4name.text = "";
                              Char4speech.text = "";
                              Char5name.text = "";
                              Char5speech.text = "";
                              Char6name.text = "";
                              Char6speech.text = "";

                             }
                             //Go to happy ending!



              //If you came with CHris and Evans (WITHOUT COMMUNICATION):
                else if (primeInt == 900){
                DialogueDisplay.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "POTUS";
                Char2speech.text = "Thank you for coming so such short notice, Agent Chris and Agent Evans. I believe you have a foreign being with you?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";

                         }
                         else if (primeInt == 504){
                         DialogueDisplay.SetActive(true);
                         DialogueDisplay.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "CHRIS";
                         Char3speech.text = "Yes, sir . A, meet President Smithwell, one of the leading figures in our government. President Smithwell, this is A, the foreign alien who brings valuable intel.";
                         Char4name.text = "";
                         Char4speech.text = "";
                         Char5name.text = "";
                         Char5speech.text = "";
                         Char6name.text = "";
                         Char6speech.text = "";

                                  }
                                  else if (primeInt == 504){
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
                                  Char5speech.text = "Hmph! We’ll be the judge of that, Agent Chris. What were you thinking  anyway, housing this foreign “thing” and arranging this meeting anyway? This thing could be a spy, trying to find a weak point in our defesnes!)";
                                  Char6name.text = "";
                                  Char6speech.text = "";

                                  }
                                  else if (primeInt == 504){
                                  DialogueDisplay.SetActive(true);
                                  DialogueDisplay.SetActive(true);
                                  Char1name.text = "";
                                  Char1speech.text = "";
                                  Char2name.text = "POTUS";
                                  Char2speech.text = "Stand down, Stillwell. It was not your choice to make back in/nthe White House whether I should meet this alien or not and it is most certainly not your choice now who I meet with now. Is that understood?";
                                  Char3name.text = "";
                                  Char3speech.text = "";
                                  Char4name.text = "";
                                  Char4speech.text = "";
                                  Char5name.text = "";
                                  Char5speech.text = "";
                                  Char6name.text = "";
                                  Char6speech.text = "";

                                  }
                                  else if (primeInt == 504){
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
                                  Char5speech.text = "Hmph! Yes, sir.";
                                  Char6name.text = "";
                                  Char6speech.text = "";

                                }
                                else if (primeInt == 504){
                                DialogueDisplay.SetActive(true);
                                DialogueDisplay.SetActive(true);
                                Char1name.text = "";
                                Char1speech.text = "";
                                Char2name.text = "POTUS";
                                Char2speech.text = "Before we start, I’m lead to believe that you are unable to speak English naturally?";
                                Char3name.text = "";
                                Char3speech.text = "";
                                Char4name.text = "";
                                Char4speech.text = "";
                                Char5name.text = "";
                                Char5speech.text = "";
                                Char6name.text = "";
                                Char6speech.text = "";

                              }
                              else if (primeInt == 504){
                              DialogueDisplay.SetActive(true);
                              DialogueDisplay.SetActive(true);
                              Char1name.text = "";
                              Char1speech.text = "";
                              Char2name.text = "POTUS";
                              Char2speech.text = "Well it just so happens that we have a device that is able to replicate alien speech into something we understand./nI doubt it’s anywhere near as powerful as one you might use but this will have to do./nIt’s quite important that we understand each other clearly for a discussion such as this.";
                              Char3name.text = "";
                              Char3speech.text = "";
                              Char4name.text = "";
                              Char4speech.text = "";
                              Char5name.text = "";
                              Char5speech.text = "";
                              Char6name.text = "";
                              Char6speech.text = "";

                            }
                            else if (primeInt == 504){
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
                            Char5name.text = "";
                            Char5speech.text = "";
                            Char6name.text = "MATILDA";
                            Char6speech.text = "Aw man. I was hoping I could show off my powers.";

                          }
                          else if (primeInt == 504){
                          DialogueDisplay.SetActive(true);
                          DialogueDisplay.SetActive(true);
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "";
                          Char2speech.text = "";
                          Char3name.text = "";
                          Char3speech.text = "";
                          Char4name.text = "";
                          Char4speech.text = "EVANS";
                          Char5name.text = "Don’t worry, honey, You did good. Where would we have been if you didn’t see A for what he was in the first place? ";
                          Char5speech.text = "";
                          Char6name.text = "";
                          Char6speech.text = "";

                        }
                        else if (primeInt == 504){
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
                        Char5name.text = "";
                        Char5speech.text = "";
                        Char6name.text = "MATILDA";
                        Char6speech.text = "I guess.";

                      }
                      else if (primeInt == 504){
                      DialogueDisplay.SetActive(true);
                      DialogueDisplay.SetActive(true);
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "POTUS";
                      Char2speech.text = "So Alien, I was led to believe that you have intel for us about this impending invasion?";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "";
                      Char4speech.text = "";
                      Char5name.text = "";
                      Char5speech.text = "";
                      Char6name.text = "";
                      Char6speech.text = "";

                    }
                    else if (primeInt == 504){
                    DialogueDisplay.SetActive(true);
                    DialogueDisplay.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "Yes, I do but it seems that you already have some knowledge of this already.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
                    Char4name.text = "";
                    Char4speech.text = "";
                    Char5name.text = "";
                    Char5speech.text = "";
                    Char6name.text = "";
                    Char6speech.text = "";

                  }
                  else if (primeInt == 504){
                  DialogueDisplay.SetActive(true);
                  DialogueDisplay.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "POTUS";
                  Char2speech.text = "Two weeks ago , NASA’s satellites and our probes in space sent back data of an unknown surge of energy radiating from far out of space and settling near Earth./nThese surges of energy have been increasing in strength since then and about two days ago,/nwe’ve begin receiving images of what seems to be small tears in outer space near the ozone layer. Our camera couldn’t capture it precisely but we know for sure/nthat they were not natural, thought we didn’t have an answer for what it was. But now it seems like we do";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";
                  Char6name.text = "";
                  Char6speech.text = "";

                }
                else if (primeInt == 504){
                DialogueDisplay.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Those surges of energy are the result of my people, the Giniperians, sending trans-gravitational pulses near Earth in order to rip open a portal,/nbig enough to allow our warships to come through. I was able to ride one of those pulses to Earth though it wrecked my ship due to the instability of the portal./nHowever, once enough energy has been gathered to stabilize the wormhole, within hours, by my calculations, the portal should be completed and the full /nmight of Giniperia will come through to raze this land.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";

              }
              else if (primeInt == 504){
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
              Char5speech.text = "So you’re saying that no matter what we do now, it’s inevitable that your kind will come through and began purging this planet of our resources?";
              Char6name.text = "";
              Char6speech.text = "";

            }
            else if (primeInt == 504){
            DialogueDisplay.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Yes, that is the general gist of it.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Char5name.text = "";
            Char5speech.text = "";
            Char6name.text = "";
            Char6speech.text = "";

          }
          else if (primeInt == 504){
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
          Char5speech.text = "Then we should be preparing our defenses now!/nWe need to notify every country of what is coming and mobilize our armie! The Navy, Homeland Security, everything!";
          Char6name.text = "";
          Char6speech.text = "";

        }
        else if (primeInt == 504){
        DialogueDisplay.SetActive(true);
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        Char4name.text = "EVANS";
        Char4speech.text = "General Stillwell, with all due respect , do you really think trying to shore up our defenses is the best option?/nIn the best case, we would’ve needed days to prepare the armies of every country on this planet. In only a matter of hours, the 4";
        Char5name.text = "";
        Char5speech.text = "";
        Char6name.text = "";
        Char6speech.text = "";

      }
      else if (primeInt == 504){
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
      Char5speech.text = "They will be forced to face reality when they see the truth with their own eyes. Then they will know that we were right.";
      Char6name.text = "";
      Char6speech.text = "";

    }
    else if (primeInt == 504){
    DialogueDisplay.SetActive(true);
    DialogueDisplay.SetActive(true);
    Char1name.text = "";
    Char1speech.text = "";
    Char2name.text = "";
    Char2speech.text = "";
    Char3name.text = "CHRIS";
    Char3speech.text = "What good will that do us then? It doesn’t matter if we were right or wrong, we’ve lost at that point./nThe invasion will take everyone by surprise and the chain of command around the world will be in shambles.";
    Char4name.text = "";
    Char4speech.text = "";
    Char5name.text = "";
    Char5speech.text = "";
    Char6name.text = "";
    Char6speech.text = "";

  }
  else if (primeInt == 504){
  DialogueDisplay.SetActive(true);
  DialogueDisplay.SetActive(true);
  Char1name.text = "YOU";
  Char1speech.text = "And even if you humans did somehow miraculously gathered your army together within the time frame, you would still stand no chance./nYou cannot hope to defend or defeat the Giniperian’s fleet. Your options are few, President Smith.";
  Char2name.text = "";
  Char2speech.text = "";
  Char3name.text = "";
  Char3speech.text = "";
  Char4name.text = "";
  Char4speech.text = "";
  Char5name.text = "";
  Char5speech.text = "";
  Char6name.text = "";
  Char6speech.text = "";

}
else if (primeInt == 504){
DialogueDisplay.SetActive(true);
DialogueDisplay.SetActive(true);
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "POTUS";
Char2speech.text = "What do you suggest we do then, A? You alone have the best knowledge about this inevitable disaster.";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "";
Char4speech.text = "";
Char5name.text = "";
Char5speech.text = "";
Char6name.text = "";
Char6speech.text = "";
// Turn off "Next" button, turn on "Choice" buttons
nextButton.SetActive(false);
allowSpace = false;
Choice1a.SetActive(true); // function Choice1aFunct()
Choice1b.SetActive(true); // function Choice1bFunct()
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
                        public void Choice1cFunct(){
                               Char1name.text = "YOU";
                               Char1speech.text = "The humans have no way of winning this battle! Let's surrender.";
                               Char2name.text = "";
                               Char2speech.text = "";
                               primeInt = 699;
                               Choice1a.SetActive(false);
                               Choice1b.SetActive(false);
                               nextButton.SetActive(true);
                               allowSpace = true;

                        }
                        public void Choice1dFunct(){
                               Char1name.text = "YOU";
                               Char1speech.text = "The humans have no way of winning this battle! Let's surrender.";
                               Char2name.text = "";
                               Char2speech.text = "";
                               primeInt = 799;
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
                             }}

                    }

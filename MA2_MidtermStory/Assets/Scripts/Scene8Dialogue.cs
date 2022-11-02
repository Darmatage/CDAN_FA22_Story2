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
  public Text Char3name;
  public Text Char3speech;
 //public Text Char3name;
 //public Text Char3speech;
  public GameObject DialogueDisplay;
  public GameObject ArtChar1a;
  public GameObject ArtChar1b;
  public GameObject ArtChar2a;
 //public GameObject ArtChar2;
  public GameObject ArtBG1;
  public GameObject NextScene1Button;
  public GameObject nextButton;
  public GameHandler gameHandler;
  private bool allowSpace = true;
  public static bool hasComm=true;
  public static bool hasAi=true;
  public static bool hasProof=true;

 //public AudioSource audioSource;
    // Start is called before the first frame update
void Start(){
   DialogueDisplay.SetActive(false);
      ArtChar1a.SetActive(false);
      ArtChar1b.SetActive(false);
      ArtChar2a.SetActive(false);
      ArtBG1.SetActive(true);
      NextScene1Button.SetActive(false);
      nextButton.SetActive(true);
}



    // Update is called once per frame
    void Update(){
        if (allowSpace == true){
              if (Input.GetKeyDown("space")){
                     talking();


    }
  }
}
//Story Units:
void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
  if (primeInt == 1){
                // AudioSource.Play();
    }

    else if (primeInt == 2){
          ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(It’s that cat from before! So this creature resides here too?)";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

          if (GameHandler.hasProof==true){
                  primeInt=199;
                  Char1name.text = "YOU";
                  Char1speech.text = "Woof, woof!";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                }
              else if (GameHandler.hasComm==true){
                   primeInt=99;
                ArtChar1a.SetActive(true);
                    Char1name.text = "YOU";
                    Char1speech.text = "Hello. You look familiar.";
                    Char2name.text = "";
                    Char2speech.text = "";
                 }
}
            //scene 7a: with communication device

           else if (primeInt == 100){
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Cat";
                    Char2speech.text = "What the hell? Who are you?\nThere's no ways a dog can talk in meows.";
            }
            else if (primeInt == 101){
              ArtChar1a.SetActive(false);
                    Char1name.text = "YOU";
                    Char1speech.text = "Well that's because I'm not a dog. I've just assumed a form of one to better integrate myself into this planet.";
                    Char2name.text = "";
                    Char2speech.text = "";
            }
            else if (primeInt == 102){
              ArtChar1b.SetActive(false);
              ArtChar1a.SetActive(true);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "Cat";
                     Char2speech.text = "... Wait a minute. I remember you.\nI saw you earlier today.";
             }
             else if (primeInt == 103){
                     Char1name.text = "YOU";
                     Char1speech.text = "So .. you understood me this entire time?";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
             else if (primeInt == 104){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Cat";
                      Char2speech.text = "I did, yes. I just didn’t wish to engage with you.\nSo I played 'feral.'";
          }
           else if (primeInt == 105){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Cat";
                    Char2speech.text = "And you choose the form of the ugliest creature on this world.\nTo each their own, I guess.";
          }
          else if (primeInt == 106){
                   Char1name.text = "YOU";
                   Char1speech.text = "I didn't exactly have a lot of time to browse disguises. And I quite like this form actually.\nBut that doesn't matter. I need help now.";
                   Char2name.text = "";
                   Char2speech.text = "";
        }
        else if (primeInt == 107){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Cat";
                 Char2speech.text = "What's it in for me?";
      }
      else if (primeInt == 108){
               Char1name.text = "YOU";
               Char1speech.text = "How about not being vaporized in the giant ball of fire this planet will soon become?";
               Char2name.text = "";
               Char2speech.text = "";
    }
    else if (primeInt == 109){
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Cat";
             Char2speech.text = "Well, now you got my undivided attention. What makes you think that I'll believe you?";
  }
  else if (primeInt == 110){
           Char1name.text = "YOU";
           Char1speech.text = "I wouldn't joke about something so serious.\nI need your help in communicating with the humans of this household.";
           Char2name.text = "";
           Char2speech.text = "";
}
else if (primeInt == 111){
  ArtChar1a.SetActive(false);
  ArtChar1b.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "Ha! Sorry to break it to you bud, but you chose the wrong cat for that job.";
}
else if (primeInt == 112){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "You know, I thought aliens were smarter from what I've seen of your kind.";
}
else if (primeInt == 113){
  ArtChar1b.SetActive(false);
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "I have no way of communicating with those two besides biting or glaring at them.";
}
else if (primeInt == 114){
         Char1name.text = "YOU";
         Char1speech.text = "Well that’s great.\nIs there really no one on this planet that can communicate outside of their own species?";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 115){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "I'm afraid not.";
}
else if (primeInt == 116){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "Well .. there's one exception.";
}
else if (primeInt == 117){
         Char1name.text = "YOU";
         Char1speech.text = "Really, who?";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 118){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "The kid. For some reason, she's able to understand what I say or rather what I'm thinking.";
}
else if (primeInt == 119){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "It's kinda weird but it's convenient when I want some extra catnip.";
}
else if (primeInt == 120){
         Char1name.text = "YOU";
         Char1speech.text = "Where's this child? I haven't seen anyone else in this place.";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 121){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "She's at this placed called 'school' right now but she should be back soon.";
}
else if (primeInt == 122){
         Char1name.text = "YOU";
         Char1speech.text = "I see. Thank you for your assistance. Yout were surprisingly helpful.";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 123){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Cat";
         Char2speech.text = "Yeah, yeah. If we're done, can you go away now?/nI need my afternoon nap unless you want me to rip your tail off.";
         nextButton.SetActive(false);
         allowSpace = false;
         NextScene1Button.SetActive(true); //scene 2
    }

//Encounter without communication
else if (primeInt == 200){
      Char1name.text = "YOU";
      Char1speech.text = "Woof, woof!";
      Char2name.text = "";
      Char2speech.text = "";
}
  else if (primeInt == 201){
    ArtChar1b.SetActive(true);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "Cat";
      Char2speech.text = "MRROW!";
}
else if (primeInt == 202){
      Char1name.text = "YOU";
      Char1speech.text = "(Gh, this creature and its temper..!)";
      Char2name.text = "";
      Char2speech.text = "";
}
  else if (primeInt == 203){
      Char1name.text = "YOU";
      Char1speech.text = "Woof woof!";
      Char2name.text = "";
      Char2speech.text = "";
}
else if (primeInt == 204){
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "Cat";
      Char2speech.text = "MROWWWW!!!";
      Char3name.text = "";
      Char3speech.text = "";
}
  else if (primeInt == 205){
      ArtChar2a.SetActive(true);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "Evan";
      Char3speech.text = "Woah there new guy! Careful around Frank. He's a prickly one.\nYou wouldn't want to lose an eye, would you?";
}
else if (primeInt == 206){
    ArtChar1a.SetActive(false);
      Char1name.text = "YOU";
      Char1speech.text = "(Lose an eye? What is this vicious beast and why do thesse humans have such a dangerous creature in their living quarters?";
      Char2name.text = "";
      Char2speech.text = "";

}
else if (primeInt == 207){
      Char1name.text = "YOU";
      Char1speech.text = "(Is there anyone here rational enough to communicate with..?!)";
      Char2name.text = "";
      Char2speech.text = "";
      nextButton.SetActive(false);
      allowSpace = false;
      NextScene1Button.SetActive(true); //scene 2

}



  }


    public void SceneChange1Funct(){
                         SceneManager.LoadScene("Scene9");
                  }
             }

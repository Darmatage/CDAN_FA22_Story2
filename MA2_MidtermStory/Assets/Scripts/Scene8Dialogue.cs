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
                Char1speech.text = "Hm, this specimen doesn't look human. Perhaps a little communicaton won't hurt?";
                Char2speech.text = "";

                if (GameHandler.hasComm == true){primeInt = 199;}
                if(GameHandler.hasAi == true){primeInt = 199;}
                else if (GameHandler.hasProof == true){primeInt = 299;}

}
            //scene 7a: with communication device

           else if (primeInt == 200){
             ArtChar1a.SetActive(false);
                    Char1name.text = "YOU";
                    Char1speech.text = "Hello, fellow citizen of this planet.";
                    Char2name.text = "";
                    Char2speech.text = "";
            }
           else if (primeInt == 201){
             ArtChar1a.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Frank";
                    Char2speech.text = "What the hell? Who the crap are you? /nThere's no ways a dog can talk in Meows.";
                    //gameHandler.AddPlayerStat(1);
            }
            else if (primeInt == 202){
              ArtChar1a.SetActive(false);
                    Char1name.text = "YOU";
                    Char1speech.text = "Well it's because I'm not a dog. I've just assumed a form of one to better integrate myself into this planet.";
                    Char2name.text = "";
                    Char2speech.text = "";
            }

           else if (primeInt == 203){
             ArtChar1a.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Frank";
                    Char2speech.text = "Hmm. So you choose the form of the ugliest creature on this world. To each their own, I guess.";
          }
          else if (primeInt == 204){
              ArtChar1a.SetActive(false);
                   Char1name.text = "YOU";
                   Char1speech.text = "I didn't exactly have a lot of time to browse disguises. And I quite like this form actually./nBUt that doesn't matter. I need help now.";
                   Char2name.text = "";
                   Char2speech.text = "";
        }
        else if (primeInt == 205){
           ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Frank";
                 Char2speech.text = "What's it in for me?";
      }
      else if (primeInt == 206){
          ArtChar1a.SetActive(false);
               Char1name.text = "YOU";
               Char1speech.text = "Um...not being vaporized in the giant ball of fire this planet will soon become?";
               Char2name.text = "";
               Char2speech.text = "";
    }
    else if (primeInt == 207){
      ArtChar1a.SetActive(true);
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Frank";
             Char2speech.text = "Well, now you got my undivided attention. What makes you think that I'll believe you?";
  }
  else if (primeInt == 208){
    ArtChar1a.SetActive(false);
           Char1name.text = "YOU";
           Char1speech.text = "I wouldn't joke about something so serious. I need your help in communicating with the humans of this household.";
           Char2name.text = "";
           Char2speech.text = "";
}
else if (primeInt == 209){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Frank";
         Char2speech.text = "Hah! Sorry to break it to you bud, but you chose the wrong cat for that job. You know, I thought aliens were smarter from what I've seen of your kind. I have no way of communicating with those two there that can communicate outside of their own species?";
}
else if (primeInt == 210){
  ArtChar1a.SetActive(false);
         Char1name.text = "YOU";
         Char1speech.text = "Well, that's great. Is there really no one on this planet that can communicate outside of their own species?";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 211){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Frank";
         Char2speech.text = "Afraid not.";
}
else if (primeInt == 212){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Frank";
         Char2speech.text = "Well there's one exception.";
}
else if (primeInt == 213){
  ArtChar1a.SetActive(false);
         Char1name.text = "YOU";
         Char1speech.text = "Really, who?";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 214){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Frank";
         Char2speech.text = "The kid of those two guys./nFor some reason, she's able to understand what I say or rather what I'm thinking./nIt's kinda weird but it's convenient when I want some extra catnip.";
}
else if (primeInt == 215){
  ArtChar1a.SetActive(false);
         Char1name.text = "YOU";
         Char1speech.text = "Where's this child? I haven't seen anyone else in this place.";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 216){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Frank";
         Char2speech.text = "She's at school right now but she should be back pretty soon.";
}
else if (primeInt == 217){
  ArtChar1a.SetActive(false);
         Char1name.text = "YOU";
         Char1speech.text = "I see. Thank you for your assistance. Yout were surprisingly helpful.";
         Char2name.text = "";
         Char2speech.text = "";
}
else if (primeInt == 218){
  ArtChar1a.SetActive(true);
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "Frank";
         Char2speech.text = "(yawns)Yeah, yeah. If we're done, can you go away now? I need my afternoon nap unless you want me to rip your tail off.";
         nextButton.SetActive(false);
         allowSpace = false;
      NextScene1Button.SetActive(true); //scene 2
    }

//Encounter without communication
else if (primeInt == 300){
  ArtChar1a.SetActive(false);
      Char1name.text = "YOU";
      Char1speech.text = "Woof, woof!";
      Char2name.text = "";
      Char2speech.text = "";
}
  else if (primeInt == 301){
    ArtChar1a.SetActive(true);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "Frank";
      Char2speech.text = "MRROW!";
      nextButton.SetActive(false);
      allowSpace = false;
      NextScene1Button.SetActive(true); //scene 2
}
else if (primeInt == 302){
  ArtChar1a.SetActive(false);
      Char1name.text = "YOU";
      Char1speech.text = "(That's an extreme reaction!)";
      Char2name.text = "";
      Char2speech.text = "";
}
  else if (primeInt == 303){
      ArtChar1a.SetActive(false);
      Char1name.text = "YOU";
      Char1speech.text = "Woof woof!";
      Char2name.text = "";
      Char2speech.text = "";
      nextButton.SetActive(false);
      allowSpace = false;
      NextScene1Button.SetActive(true); //scene 2
}
else if (primeInt == 304){
    ArtChar1a.SetActive(true);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "Frank";
      Char2speech.text = "MROWWWW!!!";
}
  else if (primeInt == 305){
      ArtChar2a.SetActive(true);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "";
      Char2speech.text = "Evan";
      Char3name.text = "Woah there new guy! Careful around Frank. He's a prickly one. You wouldn't want to lose an eye, would you?";
      nextButton.SetActive(false);
      allowSpace = false;
      NextScene1Button.SetActive(true); //scene 2
}
else if (primeInt == 306){
    ArtChar1a.SetActive(false);
      Char1name.text = "YOU";
      Char1speech.text = "(Lose an eye? What is this vicious beast and why do thesse humans have such a dangerous creature in their living quarters? Is there anyone rational enough to communicate with?)";
      Char2name.text = "";
      Char2speech.text = "";
      GameHandler.hasProof = true;
      nextButton.SetActive(false);
      allowSpace = false;
      NextScene1Button.SetActive(true); //scene 2

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


    void SceneChange1(){
                         SceneManager.LoadScene("Scene9");
                  }
             }
        }

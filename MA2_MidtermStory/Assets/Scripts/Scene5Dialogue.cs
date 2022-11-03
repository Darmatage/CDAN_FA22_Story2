using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		    public Text Char3name;
		    public Text Char3speech;
		    public Text Char4name;
		    public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //EvanNeutral
        public GameObject ArtChar1b; //EvanHappy
        public GameObject ArtChar1c; //EvanSurprised
        public GameObject ArtChar1d; //EvanAngry
        public GameObject ArtChar1e; //EvanAnnoyed
        public GameObject ArtChar2a; //ChrisNeutral
        public GameObject ArtChar2b; //ChrisHappy
        public GameObject ArtChar2c; //ChrisSurprised
        public GameObject ArtChar2d; //ChrisAngry
        public GameObject ArtChar2e; //ChrisAnnoyed
        public GameObject ArtChar3a; //PixeliSmile
        public GameObject ArtChar3b; //PixeliBroken
		//public GameObject ArtChar4;
        public GameObject ArtBG1;
        //public GameObject Choice1a;
        //public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar2d.SetActive(false);
        ArtChar2e.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtBG1.SetActive(true);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);
if (GameHandler.hasAi==true){
    primeInt=1;
    }
    else if ((GameHandler.hasComm==true)||(GameHandler.hasProof==true)){
               DialogueDisplay.SetActive(true);
               Char1name.text = "YOU";
               Char1speech.text = "(I'm really here! Human containment units are so .. square.)";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "";
               Char3speech.text = "";
               Char4name.text = "";
               Char4speech.text = "";
      primeInt=99;
    }
}

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void talking(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
            ArtChar3a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "Sir, we seem to have arrived in a living facility.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
				        Char4speech.text = "";
        }
       else if (primeInt == 3){
            ArtChar3a.SetActive(false);
            ArtChar3b.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "How–ho–ho shou-should–o-we–-!";
        }
       else if (primeInt ==4){
         ArtChar3b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Pixeli?!\n(.. Snargleflat, the transition from the ship’s generator must’ve been too much.)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
      else if (primeInt ==5){
                 Char1name.text = "YOU";
                 Char1speech.text = "(She’s broken and I don’t think I have the resources or the time to fix her.)\n(Maybe the humans can help? ..)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 //gameHandler.AddPlayerStat(1);
         }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(How do I get the attention of the humans in this containment unit? Perhaps this could work.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 7){
                 Char1name.text = "YOU";
                 Char1speech.text = "BARK! BARK!";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
       else if (primeInt == 8){
         DialogueDisplay.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
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
         ArtChar1c.SetActive(false);
         ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text = "Oh my god. Chris, look! It's so cute!";
                Char4name.text = "";
				        Char4speech.text = "";
        }
       else if (primeInt ==10){
         ArtChar2c.SetActive(false);
         ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				        Char4name.text = "Chris";
				        Char4speech.text = "Yeah. He's a cute little guy alright. Weird how we haven't seen him around before.";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "It doesn’t look like he has a collar. .. And the poor thing looks like he’s starving!";
                Char4name.text = "";
				        Char4speech.text = "";
        }

       else if (primeInt == 12){
         ArtChar2a.SetActive(false);
         ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = " ... What if he hasn’t had his rabies shot?";
		}
		else if (primeInt == 13){
      ArtChar1b.SetActive(false);
      ArtChar1d.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
				Char3name.text = "Evan";
				Char3speech.text = "Oh come on: the vet’s closed now and he needs to eat! We’ll take him in first thing in the morning.?";
        Char4name.text = "";
        Char4speech.text = "";
		}
    else if (primeInt == 14){
      ArtChar1d.SetActive(false);
      ArtChar1a.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "Evan";
        Char3speech.text = "How about that?";
        Char4name.text = "";
        Char4speech.text = "";
    }
		else if (primeInt == 15){
      ArtChar2d.SetActive(false);
      ArtChar2a.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
				Char4name.text = "Chris";
				Char4speech.text = "Hm. .. Alright, sure. I bet Matilda will get a kick out of this too, hon.";
		}
		else if (primeInt == 16){
      ArtChar1a.SetActive(false);
      ArtChar1b.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
				Char3name.text = "Evan";
				Char3speech.text = "For sure! Come on, little buddy.";
        Char4name.text = "";
        Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                nextButton.SetActive(false);
		}
    else if (primeInt ==100){
      ArtChar3b.SetActive(false);
             Char1name.text = "YOU";
             Char1speech.text = "(Now, how do I get the attention of the humans here? Perhaps this could work.)";
             Char2name.text = "";
             Char2speech.text = "";
}
else if (primeInt == 101){
         Char1name.text = "YOU";
         Char1speech.text = "BARK! BARK!";
         Char2name.text = "";
         Char2speech.text = "";
 }
else if (primeInt == 102){
  DialogueDisplay.SetActive(false);
  ArtChar1c.SetActive(true);
  ArtChar2c.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        Char4name.text = "";
        Char4speech.text = "";
        //gameHandler.AddPlayerStat(1);
}
else if (primeInt == 103){
  DialogueDisplay.SetActive(true);
  ArtChar1c.SetActive(false);
  ArtChar1b.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "Evan";
        Char3speech.text = "Oh my god. Chris, look! It's so cute!";
        Char4name.text = "";
        Char4speech.text = "";
}
else if (primeInt ==104){
  ArtChar2c.SetActive(false);
  ArtChar2a.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        Char4name.text = "Chris";
        Char4speech.text = "Yeah. He's a cute little guy alright. Weird how we haven't seen him around before.";
}
else if (primeInt == 105){
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "Evan";
        Char3speech.text = "It doesn’t look like he has a collar. .. And the poor thing looks like he’s starving!";
        Char4name.text = "";
        Char4speech.text = "";
}

else if (primeInt == 106){
  ArtChar2a.SetActive(false);
  ArtChar2d.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        Char4name.text = "Chris";
        Char4speech.text = " ... What if he hasn’t had his rabies shot?";
}
else if (primeInt == 107){
  ArtChar1b.SetActive(false);
  ArtChar1d.SetActive(true);
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "Oh come on: the vet’s closed now and he needs to eat! We’ll take him in first thing in the morning.\nHow about that?";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt == 108){
  ArtChar2d.SetActive(false);
  ArtChar2a.SetActive(true);
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "Chris";
Char4speech.text = "Hm. .. Alright, sure. I bet Matilda will get a kick out of this too, hon.";
}
else if (primeInt == 109) {
  ArtChar1d.SetActive(false);
  ArtChar1b.SetActive(true);
Char1name.text = "";
Char1speech.text = "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "For sure! Come on, little buddy.";
Char4name.text = "";
Char4speech.text = "";
nextButton.SetActive(false);
        allowSpace = false;
        NextScene1Button.SetActive(true);
        nextButton.SetActive(false);
}
}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6");
        }

}

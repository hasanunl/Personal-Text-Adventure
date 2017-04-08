using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States { corridor,door,salon,room,phone,cat,bed,salon2,room2,salon3,phone2,cat2,phone3,room3};
    private States playerState;
	
	void Start () {
        playerState = States.door;    
	}
	
	// Update is called once per frame
	void Update () {
             
        if(playerState==States.door)
        {
            door();
        }
        else if (playerState==States.corridor)
        {
            corridor();
        }
        else if (playerState == States.salon)
        {
            salon();
        }
        else if (playerState == States.phone)
        {
            phone();
        }
        else if (playerState == States.cat)
        {
            cat();
        }
        else if (playerState == States.room)
        {
            room();
        }
        else if (playerState == States.bed)
        {
            bed();
        }
        else if (playerState == States.salon2)
        {
            salon2();
        }
        else if (playerState == States.room2)
        {
            room2();
        }
        else if (playerState == States.salon3)
        {
            salon3();
        }
        else if (playerState == States.phone2)
        {
            phone2();
        }
        else if (playerState == States.phone3)
        {
            phone3();
        }
        else if (playerState == States.cat2)
        {
            cat2();
        }
        else if (playerState == States.room3)
        {
            room3();
        }

    }

    void door ()
    {
        text.text = " You just arrived to your home, after a very tiring day at your school." +
           "You looked at your homes brown steel door with your tired body and do \n" +
           " A - Ring the bell.\n" +
           " B - Go back. ";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.salon;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            playerState = States.corridor;      
        }
    }

    void corridor ()
    {
        text.text = "You start to blankly stare at the walls.\n" +
                " A - Ring the bell.\n";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.salon;
        }
    }

    void salon ()
    {
        text.text = "You came to the salon and saw your white salon set and walls." +
            "Your mother is watching one of these marriage realty shows while your cat"+
            " is sitting with a grumpy face on the sofa."+
            " You sit on one of the couches and do \n" +
            " A - Look at your phone.\n" +
            " B - Pet your cat.";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.phone;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            playerState = States.cat;
        }
    }

    void salon2()
    {
        text.text = "You came back to the salon but your mother wasn't there.She is cooking some meals." +
            "Your cat was also gone to the balcony.So you do\n" +
            " A - Look at your phone.\n";

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.phone2;
        }
    }

    void salon3()
    {
        text.text = "You came back to the salon but your mother wasn't there.She is cooking some meals." +
            "Your cat is still sitting on the coach.So you do\n" +
            " A - Pet your cat.\n";

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.cat2;
        }
    }

    void phone()
    {
        text.text = "You looked at some photos on social media, than played some card games." +
                "You finally got the card you wanted.After you do \n"+
                " A - Go to your room.\n";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.room2;
        }
    }

    void phone2()
    {
        text.text = "You played some card games again and you lost a rank." +
                "After that you do \n" +
                " A - Go to bed with dissapointment.\n";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.bed;
        }
    }

    void phone3()
    {
        text.text = "You played some card games again and with the help of your new card you " +
                "gained a new rank.After that you do \n" +
                " A - Go to bed with joy of victory.\n";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.bed;
        }
    }

    void cat()
    {
        text.text = "You pet your cat for a while.But it got angry and bited you than gone to the balcony.You laughed a bit because of " +
                "its cuteness.Then you \n"+
                " A - Go to your room.\n";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.room;
        }
    }

    void cat2()
    {
        text.text = "You pet your cat for a while.But it got angry and bited you than gone to the balcony.You laughed a bit because of " +
                "its cuteness.Then you \n" +
                " A - Go to your room.\n";
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.room3;
        }
    }

    void room()
    {
        text.text = "You came to your room.It is a room with white painted walls just like" +
            " the salon and it is quite hot because it looks directly "+
            "to the sun.You played with your console a bit.Than you do\n" +
            " A - Go to sleep.\n" +
            " B - Go back to salon.\n" +
            " C - Play card games with your phone.";
            
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.bed;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            playerState = States.salon2;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            playerState = States.phone2;
        }
    }

    void room2()
    {
        text.text = "You came to your room.It is a room with white painted walls just like" +
            " the salon and it is quite hot because it looks directly " +
            "to the sun.You played with your console a bit.Than you do\n" +
            " A - Go to sleep.\n" +
            " B - Go back to salon.\n" +
            " C - Play card games with your phone.";

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.bed;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            playerState = States.salon3;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            playerState = States.phone3;
        }
    }

    void room3()
    {
        text.text = "You came back to your room.\n"+
            " A - Go to sleep.\n"+
            " B -  Play card games with your phone.";

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerState = States.bed;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            playerState = States.phone3;
        }

    }


    void bed()
    {
        text.text = "You go to sleep for a new tomorrow.\n\n"+
            " R - Start a new game.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerState = States.door;
        }

    }

}

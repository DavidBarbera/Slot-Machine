Slot Machine Assignment

Rob Allen								 	Design Lead
David Barbera									Technical Lead
Mircea Catana 									Director of Content

For this project a 3D slot machine was built in 3ds Max (by Rob) and then imported into Unity. Separate elements were built so that they could then be transformed independently with C# coding, to achieve different results.
Slot 1
Slot 2
Slot 3
Handle

Mircea started the project off by setting up the Github details to ensure that we would all work collaboratively on the same Unity project. We then worked out, as a team, the different outcomes we wanted to achieve for the game and following that divided up the tasks between us. 

Tasks:
Mentor (Mircea)
Build Slot Machine model and initial animation (Rob)
Slots to spin when button pressed (David)
Handle to rotate when button pressed (Rob)
Cheating mechanic (David)
Trigger an outcome when the players ‘wins’

In Visual Studios we started off by coding Slots 1, 2 and 3 to spin when the space button was pressed and stop after a certain time.
We then added some cheating mechanics so that by pressing certain buttons the player can affect the position of Slots 1, 2 and 3. Q, W and E respectively would alter the rotation of the slots by 90 degrees ensuring a different image was displayed.

using UnityEngine;
using System.Collections;

public class Spin1 : MonoBehaviour
{

    private bool isSpinning = false;
    private float spinCounter = 0;
    private float spinStep = 360.0f / 4.0f;
    public int value = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            isSpinning = !isSpinning;
//for Spin2 and Spin3 wheels the range interval of randomness is
// (130,160) and (170,200) respectively, so they all stop in sequence.
            spinCounter = Random.Range(90, 120);
        }

        if (isSpinning && spinCounter > 0)
        {
            transform.Rotate(new Vector3(0, 0, 1), spinStep);
            --spinCounter;
            value = (value + 1) % 4;
        }
        else if (isSpinning && spinCounter <= 0)
        {
            isSpinning = false;
        }
       //for Spin2 and Spin3 wheels the key code is W and E respectively.
        if (isSpinning == false && Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 1), spinStep);
        }
    }
}



Afterwards we wanted the Handle to rotate when the player pressed Space:
using UnityEngine;
using System.Collections;

public class Handle : MonoBehaviour {
    int angle = 90;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 1, 0), angle);
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 1, 0), -angle);
        }
    }
}






Finally we wanted to print some text for when the player won. To do this we first needed to trigger the slots so that the game would now ‘how’ to win. Then on this outcome the phrase “You Win” would be printed. However, we encountered a problem with this so we couldn’t complete this task.



At the end of the project we had too many problems merging pull requests so we decided to start one of the pull requests as a separate project and work from that.

Here is a link to our final game:
https://youtu.be/zxE8qqWVJq0

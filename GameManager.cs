using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    //asdasdasd
    public MemoryCard firstSelectedCard;
    public MemoryCard secondSelectedCard;

    private bool canClick = true;

    public void CardClicked(MemoryCard card) 
    {

        if (canClick == false)
            return;

        card.transform.localEulerAngles = new Vector3(-90, 0, 0);
        card.targetHeight = 0.5f;

        if(firstSelectedCard == null) {
            firstSelectedCard = card;
        }
        else
        {
            secondSelectedCard = card;

            

            Invoke("CheckMatch", 2);
            
        }
    }
     public void CheckMatch() 
     {
        if(firstSelectedCard.id == secondSelectedCard.id & firstSelectedCard != secondSelectedCard) 
            {
                Destroy(firstSelectedCard.gameObject);
                Destroy(secondSelectedCard.gameObject);
            } else
            {
                firstSelectedCard.transform.localEulerAngles = new Vector3(90, 0 , 0);
                secondSelectedCard.transform.localEulerAngles = new Vector3(90, 0 , 0);
                
            }
            firstSelectedCard.targetHeight = 2.04f;
            secondSelectedCard.targetHeight = 2.04f;

            canClick = true;
     }
}

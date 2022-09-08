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

        card.targetRotation = 90;
        card.targetHeight = 1.5f;

        if(firstSelectedCard == null) {
            firstSelectedCard = card;
        }
        else
        {
            secondSelectedCard = card;
            Invoke("CheckMatch", 1);
            
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
                firstSelectedCard.transform.localEulerAngles = new Vector3(-90, 0, 0);
                secondSelectedCard.transform.localEulerAngles = new Vector3(-90, 0, 0);

                firstSelectedCard.targetHeight = 0.05f;
                secondSelectedCard.targetHeight = 0.05f;
            }
            firstSelectedCard = null;
            secondSelectedCard = null;
            canClick = true;
     }
}

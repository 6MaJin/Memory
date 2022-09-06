using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    

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

            canClick = false;

            Invoke("CheckMatch", 2);
            
        }
    }
     public void CheckMatch() 
     {
        if(firstSelectedCard.id == secondSelectedCard.id) 
            {
                Destroy(firstSelectedCard.gameObject);
                Destroy(secondSelectedCard.gameObject);
            } else
            {
                firstSelectedCard.transform.localEulerAngles = new Vector3(-90, 0 , 0);
                secondSelectedCard.transform.localEulerAngles = new Vector3(-90, 0 , 0);
            }
            firstSelectedCard.transform.localEulerAngles = new Vector3(-90, 0 , 0);
            firstSelectedCard.targetHeight = 0.04f;
            secondSelectedCard.targetHeight = 0.04f;

            canClick = true;
     }
}

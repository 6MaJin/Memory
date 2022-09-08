using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clipCardUp;
    public AudioClip clipCardDown;
    public AudioClip clipCardMatch;

    public GameObject[] allCards;
    public List<Vector3> allPositions = new List<Vector3>();


    private MemoryCard firstSelectedCard;
    private MemoryCard secondSelectedCard;

    private bool canClick = true;

    public void CardClicked(MemoryCard card) 
    {

        if (canClick == false || card == firstSelectedCard)
            return;

        card.targetRotation = -90;
        card.targetHeight = 1.5f;

        if(firstSelectedCard == null) {
            firstSelectedCard = card;
        }
        else
        {
            secondSelectedCard = card;
            canClick = false;
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
                //firstSelectedCard.transform.localEulerAngles = new Vector3(-90, 0, 0);
                //secondSelectedCard.transform.localEulerAngles = new Vector3(-90, 0, 0);

                firstSelectedCard.targetRotation = -90;
                secondSelectedCard.targetRotation = -90;

                firstSelectedCard.targetHeight = 0.01f;
                secondSelectedCard.targetHeight = 0.01f;
            }
            firstSelectedCard = null;
            secondSelectedCard = null;
            canClick = true;
     }
}

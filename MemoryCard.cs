using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    public int id;
    
    public float targetHeight = 6f;
    public float targetRotation = - 90f;

    public void OnMouseDown()
    {
        Debug.Log(id);
        FindObjectOfType<GameManager>().CardClicked(this);
    }
    private void Update() 
    {
        float heightValue = Mathf.MoveTowards(transform.position.y, targetHeight, 1 * Time.deltaTime);
    }
}

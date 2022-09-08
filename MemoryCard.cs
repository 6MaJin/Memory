using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    public int id;

    public float targetHeight = 0.01f;
    public float targetRotation = 90f;
    public void OnMouseDown()
    {
        Debug.Log(id);
        FindObjectOfType<GameManager>().CardClicked(this);
    }

    private void Update() 
    {
        // move up/down
        float heightValue = Mathf.MoveTowards(transform.position.y, targetHeight, 0.5f * Time.smoothDeltaTime);
        transform.position = new Vector3(transform.position.x, heightValue, transform.position.z);

        // rotate X
        Quaternion rotationValue = Quaternion.Euler(targetRotation, 0, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotationValue, 10 * Time.deltaTime);

    }
}

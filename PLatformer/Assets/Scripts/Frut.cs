using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frut : MonoBehaviour
{
    public GameManager ScriptGameManager;
    public string nameFruct;
    private void FixedUpdate()
    {
        transform.localPosition -= new Vector3(0, 2.5f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Zone")
        {
            ScriptGameManager.Score--;
        }
        else if (collision.gameObject.tag == nameFruct)
        {
            ScriptGameManager.Score++;
        }
        else
        {
            ScriptGameManager.Score--;
        }
        Destroy(gameObject);
    }
}


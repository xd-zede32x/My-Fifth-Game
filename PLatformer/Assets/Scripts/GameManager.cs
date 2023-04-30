using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> Fricts;
    [SerializeField] private List<GameObject> SpawnFruct;
    [SerializeField] private List<GameObject> Chartes;

    public int Score;

    [SerializeField] private Text scoreText;

    private void OnEnable()
    {
        Generateted();
        StartCoroutine(GeneratedFruct());
    }

    private void FixedUpdate()
    {
        scoreText.text = Score.ToString();
    }

    private void Generateted()
    {
        int fruct = 4;
        for (int i = 0; i < 4; i++)
        {
            int randomfryct = Random.Range(0, fruct);

            Fricts[randomfryct].transform.localPosition = Chartes[i].transform.localPosition + new Vector3(10, 120, 0);
            Fricts[randomfryct].transform.SetParent(Chartes[i].transform);
            Chartes[i].tag = Fricts[randomfryct].name;

            Fricts.RemoveAt(randomfryct);

            fruct--;
        }
    }

    private IEnumerator GeneratedFruct()
    {
        while (true)
        {
            int randomFruct = Random.Range(0, SpawnFruct.Count);
            string nameFruct = SpawnFruct[randomFruct].name;

            GameObject gameObject = Instantiate(SpawnFruct[randomFruct]);

            gameObject.transform.SetParent(transform);
            gameObject.transform.localPosition = new Vector2(0, 620);
            gameObject.transform.localScale = new Vector3(1, 1);


            gameObject.AddComponent<Frut>();


            gameObject.GetComponent<Frut>().ScriptGameManager = GetComponent<GameManager>();
            gameObject.GetComponent<Frut>().nameFruct = nameFruct;

            yield return new WaitForSeconds(5);
        }
    }

    public void CharacterOne()
    {
        StartCoroutine(Char(0, Chartes[0].transform.localPosition));
    }

    public void CharacterTwo()
    {
        StartCoroutine(Char(1, Chartes[1].transform.localPosition));
    }

    public void CharacterTree()
    {
        StartCoroutine(Char(2, Chartes[2].transform.localPosition));
    }

    public void CharacterFour()
    {
        StartCoroutine(Char(3, Chartes[3].transform.localPosition));
    }

    IEnumerator Char(int num, Vector3 lastPos)
    {
        Chartes[num].transform.localPosition = new Vector2(0, -100);
        yield return new WaitForSeconds(0.4f);

        Chartes[num].transform.localPosition = lastPos;

    }
}

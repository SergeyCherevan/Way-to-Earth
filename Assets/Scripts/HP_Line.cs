using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class HP_Line : MonoBehaviour
{
    public GameObject heartPrefab;
    public List<GameObject> hearts;

    public int startHP;
    public int HP;

    public GameObject gameManager;

    void Start()
    {
        startHP = hearts.Count;
        HP = startHP;

        //hearts = new List<GameObject>(startHP);
        //for (int i = 0; i < startHP; i++)
        //{
        //    hearts.Add(
        //        Instantiate(heartPrefab, transform.position, transform.rotation)
        //    );
        //    hearts[i].transform.SetParent(gameObject.transform);
        //    hearts[i].transform.Translate(new Vector3(i, 0, 0));
        //}
    }

    public void ChangeHP(int addendum)
    {
        if (addendum > 0)
        {
            for (int i = HP; i < HP + addendum; i++)
            {
                hearts.Add(
                    Instantiate(heartPrefab, transform.position, transform.rotation)
                );
                hearts[i].transform.SetParent(gameObject.transform);
                hearts[i].transform.Translate(new Vector3(i, 0, 0));
            }
            HP += addendum;
        }

        if (addendum < 0)
        {
            for (int i = HP - 1; i >= HP + addendum; i--)
            {
                Destroy(hearts[i]);
                hearts.Remove(hearts[i]);
            }
            HP += addendum;
        }

        if (HP == 0)
        {
            gameManager.GetComponent<GameManager>().Lose();
        }
    }
}

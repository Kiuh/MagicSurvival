using JetBrains.Annotations;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEditor.Experimental.Rendering;
using UnityEngine;

public class BackgroundCreator : MonoBehaviour
{
    System.Random r = new System.Random();
    [SerializeField]
    GameObject Player;
    Transform PlayerTransform;
    [SerializeField]
    GameObject CloneObj;
    SpriteRenderer[] Real_Sprites;
    [SerializeField]
    GameObject[,] backs = new GameObject[3, 3];
    private void Awake()
    {
        Sprite[] Res_Sprites = Resources.LoadAll<Sprite>("BackGrounds/" + GlobalInfo.SelectedArea);
        int count = Random.Range(0, Res_Sprites.Length/4);
        Real_Sprites = CloneObj.GetComponentsInChildren<SpriteRenderer>();
        for (int j = 0; j < 4; j++)
        {
            Real_Sprites[j].sprite = Res_Sprites[count * 4 + j];
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                backs[i,j] = GameObject.Instantiate(CloneObj, this.GetComponent<Transform>());
                backs[i, j].transform.position = new Vector3(i*10, (3-j)*10, backs[i, j].transform.position.z);
            }
        }
        PlayerTransform = Player.GetComponent<Transform>();
        CloneObj.SetActive(false);
    }
    private void Update()
    {
        if(PlayerTransform.position.x > backs[1, 1].transform.position.x + 5) 
        {
            for (int i = 0; i < 3; i++)
            {
                backs[0, i].transform.position = new Vector3(backs[0, i].transform.position.x + 30, backs[0, i].transform.position.y, backs[0, i].transform.position.z);
                Swap(0, i, 1, i);
                Swap(1, i, 2, i);
            }
        }
        else if (PlayerTransform.position.x < backs[1, 1].transform.position.x - 5)
        {
            for (int i = 0; i < 3; i++)
            {
                backs[2, i].transform.position = new Vector3(backs[2, i].transform.position.x - 30, backs[2, i].transform.position.y, backs[2, i].transform.position.z);
                Swap(2, i, 1, i);
                Swap(1, i, 0, i);
            }
        }
        else if (PlayerTransform.position.y > backs[1, 1].transform.position.y + 5)
        {
            for (int i = 0; i < 3; i++)
            {
                backs[i, 2].transform.position = new Vector3(backs[i, 2].transform.position.x, backs[i, 2].transform.position.y + 30, backs[i, 2].transform.position.z);
                Swap(i, 2, i, 1);
                Swap(i, 1, i, 0);
            }
        }
        else if (PlayerTransform.position.y < backs[1, 1].transform.position.y - 5)
        {
            for (int i = 0; i < 3; i++)
            {
                backs[i, 0].transform.position = new Vector3(backs[i, 0].transform.position.x, backs[i, 0].transform.position.y - 30, backs[i, 0].transform.position.z);
                Swap(i, 0, i, 1);
                Swap(i, 1, i, 2);
            }
        }
    }
    private void Swap(int a, int b, int a1, int b1) 
    {
        GameObject go = backs[a, b];
        backs[a, b] = backs[a1, b1];
        backs[a1, b1] = go;
    }
}

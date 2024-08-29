using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [SerializeField] GameObject Prefabs;
    private GameObject[] blocks;
    [SerializeField] int count = 10;

    // Start is called before the first frame update
    void Start()
    {
        CreateBlock();

        ColorChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBlock()
    {
        blocks = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            blocks[i] = Instantiate(Prefabs);

            if (i < count / 2)
            {
                blocks[i].transform.position = new Vector3(i, 0, 0);
            }
            else
            {
                blocks[i].transform.position = new Vector3(i - count / 2, 0, -2);
            }
        }
    }

    public void ColorChange()
    {
        Color[] colors = new Color[count / 2];
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        colors[3] = Color.black;
        colors[4] = Color.gray;
        int[] j = new int[colors.Length];

        for (int i = 0; i < count; i++)
        {
            int random = Random.Range(0, colors.Length);

            if (j[random] < 2)
            {
                blocks[i].GetComponent<Renderer>().material.color = colors[random];

                j[random] += 1;
            }
            else
            {
                i--;
            }
        }
    }
}

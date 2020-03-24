using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHelper : MonoBehaviour
{
    const float SizeW = 2.1f;
    const float SizeH = 0.55f;
    public GameObject Ground;

    public int Width = 10;
    public int Height = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Height; j++)
            {
                Vector2 pos = new Vector2(i * SizeW, j * SizeH);
                if (j % 2 == 0)
                    pos.x += SizeW / 2;
                GameObject ground = Instantiate(Ground, pos, Quaternion.identity) as GameObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit)
            {
                Debug.Log(hit.collider.name);
                hit.collider.GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
    }
}

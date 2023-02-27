using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lives : MonoBehaviour
{
    public Sprite hearthPrefab;
    private SpriteRenderer _spriteRenderer;
    private List<Sprite> hearthList;
    public float vectorx = 7.0f;
    public float vectory = 4.7f;

    public void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void GenerateHearths(int lives)
    {
        int hearthCount = 0;
        for (int i = 0; hearthCount < lives; i++)
        {
            hearthCount++;
            Instantiate(this, new Vector3(vectorx, vectory,0), Quaternion.identity);
            vectorx += 0.3f;
            hearthList.Add(hearthPrefab);
        }
        vectorx = 7.5f;
    }
    public void SubstractHearth()
    {
        var clones = GameObject.FindGameObjectsWithTag("Hearth");
        Destroy(clones[clones.Length -1 ]);
    }

}

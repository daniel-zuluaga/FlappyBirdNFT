using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GeneratorTubos : MonoBehaviour
{
    public GameObject[] obj;
    public float timeMin;
    public float timeMax;

    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    void Generate()
    {
        int randomObj = Random.Range(0, obj.Length);
        Instantiate(obj[randomObj], transform.position, Quaternion.identity);
        Invoke("Generate", Random.Range(timeMin, timeMax));
    }
}

using System.Collections;
using UnityEngine;

public class VoidTimer : MonoBehaviour
{

    public GameObject Void;
    public float waitTime;
    public Vector3 position = new Vector3(0, 0, 0);
    private IEnumerator coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coroutine = createVoid(waitTime);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    private IEnumerator createVoid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Void = GameObject.FindGameObjectWithTag("void");
        Instantiate(Void, position, Quaternion.identity);

    }
}

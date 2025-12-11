using UnityEngine;

public class voidDisapear : MonoBehaviour
{

    //Make void game object
    public GameObject Void;
    public GameObject newVoid;
    public Time time;
    public Vector3 lowestX;
    public Vector3 highestX;
   

    // Update is called once per frame
    void Update()
    {
        voidGenerator();
    }

    public void voidGenerator()
    {
        if (Time.time == 60)
        {
            float randomX = Random.Range(lowestX.x, highestX.x);
            Quaternion rotation = transform.rotation;
            newVoid = Instantiate(Void, new Vector3(randomX,0,0), rotation);
        }

        if (Time.time == 120)
        {
                float randomX = Random.Range(lowestX.x, highestX.x);
                Quaternion rotation = transform.rotation;
                newVoid = Instantiate(Void, new Vector3(randomX, 0, 0), rotation);
        }

        if (Time.time == 180)
        {
            float randomX = Random.Range(lowestX.x, highestX.x);
            Quaternion rotation = transform.rotation;
            newVoid = Instantiate(Void, new Vector3(randomX, 0, 0), rotation);
        }
    }
}

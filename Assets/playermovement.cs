using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float playerspeed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       //Höger
       if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerspeed * Time.deltaTime);
        }

        //Vänster
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerspeed * Time.deltaTime);
        }

        //upp
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * playerspeed * Time.deltaTime);
        }

        //do
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * playerspeed * Time.deltaTime);
        }

    }
}

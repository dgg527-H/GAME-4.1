using UnityEngine;

public class tankMovement : MonoBehaviour
{

    public float speed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        float throttle = Input.GetAxis("Vertical");
        float movement = throttle * speed * Time.deltaTime *-1;

        float rotate = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate (0.0f, 0.0f, movement);
        t.Rotate(0.0f, rotate, 0,0f);
    }
}

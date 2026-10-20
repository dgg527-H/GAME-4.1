using UnityEngine;

public class turretMove: MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float TurretRotate = Input.GetKey("Q") * speed * Time.deltaTime;
        transform.Rotate(0, TurretRotate, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject foodPrefab;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal
            * speed * Time.deltaTime);

        if(transform.position.x > 18)
        {
            transform.position = new Vector3(18,
                transform.position.y, transform.position.z);
        }
        if (transform.position.x < -18)
        {
            transform.position = new Vector3(-18,
                transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position +new Vector3(0, 2, 1),
                foodPrefab.transform.rotation);
        }

    }
}

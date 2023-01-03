using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;

    [SerializeField] float speedp = 20f;

    [SerializeField] float lMax = -20f;
    [SerializeField] float rMax = 20f;

    private float movementX;


    // Fonctions pour les Send Messages
    public void OnMove(InputValue value)
    {
        movementX = value.Get<float>();
    }

    
    private void Update()
    {
        //Vector3 movement = new Vector3(movementX, 0f, 0f);
        //movement.Normalize();
        transform.Translate(Vector3.right * movementX * speedp * Time.deltaTime);

        if (transform.position.x < lMax)
        {
            transform.position = new Vector3(lMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rMax)
        {
            transform.position = new Vector3(rMax, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}

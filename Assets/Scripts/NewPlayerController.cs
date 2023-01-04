using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;

    [SerializeField] float speedp = 20f;

    [SerializeField] float lMax = -20f;
    [SerializeField] float rMax = 20f;

    private float movementX;
    Vector2 movementV2;

   // bool isFeedPressed;

    // Fonctions pour les Send Messages
      public void OnMove(InputValue value)
      {
          movementX = value.Get<float>();
      }

      public void OnFeed()
      {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

      }
         

 /* 
    public void OnMoveCharacter(InputAction.CallbackContext ctx)
    {

        movementX = ctx.ReadValue<float>();
        

    }

    public void OnFeedAnimal(InputAction.CallbackContext ctx)
    {
        isFeedPressed = ctx.ReadValueAsButton();

    }   */
   

    private void Update()
    {
        
        transform.Translate(Vector3.right * movementX * speedp * Time.deltaTime);

        if (transform.position.x < lMax)
        {
            transform.position = new Vector3(lMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rMax)
        {
            transform.position = new Vector3(rMax, transform.position.y, transform.position.z);
        }


    /*    if (isFeedPressed)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //feedSound.Play();
            
        }  */

     /*  if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }  */
    }
}

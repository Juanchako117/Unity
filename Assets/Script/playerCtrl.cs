using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    public float speed = 3.5f;
	private float gravity = 10f;
	private CharacterController controller;

    public Vector3 hitPoint;
    private const float _maxDistance = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       /* RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, _maxDistance))
        {
           hitPoint = hit.point;
           var input = Input.GetButtonDown("Fire2");
				Debug.Log(input);
                if(input && hit.transform.CompareTag("RotateCube")) {
				hit.transform.gameObject.GetComponent<RotateCube>().ChangeSpin();
			}
           }*/
        PlayerMovement();
    }
    void PlayerMovement (){
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal, 0,vertical);
		Vector3 velocity = direction * speed;
		velocity = Camera.main.transform.TransformDirection(velocity);
		velocity.y -= gravity;
		controller.Move(velocity * Time.deltaTime);
	}
}

using PlayerProps;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody2D rb;
        
        [SerializeField]
        private new Camera camera;

        private Animator animator;

        private void Awake()
        {
            Player.CameraSpeed = Player.MoveSpeed * Player.BoostFactor;
        }

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        private Vector2 movement;
        private Vector2 mousePos;

        private void Update()
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Boost();
            }
            
            mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        }

        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + (movement * Player.BoostFactor) * Player.MoveSpeed * Time.fixedDeltaTime);

            Vector2 lookDirection = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;

            
            Player.CameraSpeed = Player.MoveSpeed * Player.BoostFactor;
        }

        private void Boost()
        {
            rb.AddForce(movement * Player.BlinkFactor);
        }
    }
}

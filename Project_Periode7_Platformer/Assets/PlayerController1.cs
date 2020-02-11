using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;

//namespace Platformer.Mechanics
//{
    /// <summary>
    /// This is the main class used to implement control of the player.
    /// It is a superset of the AnimationController class, but is inlined to allow for any kind of customisation.
    /// </summary>
//    public class PlayerController : KinematicObject
//    {
//            public AudioClip jumpAudio;
//            public AudioClip respawnAudio;
//            public AudioClip ouchAudio;

//        //    /// <summary>
//        //    /// Max horizontal speed of the player.
//        //    /// </summary>
//            public float maxSpeed = 7;
//        //    /// <summary>
//        //    /// Initial jump velocity at the start of a jump.
//        //    /// </summary>
//            public float jumpTakeOffSpeed = 7;

//            public JumpState jumpState = JumpState.Grounded;
//            private bool stopJump;
//        //    /*internal new*/ public Collider2D collider2d;
//            /*internal new*/ public AudioSource audioSource;
//            public Health health;
//            public bool controlEnabled = true;

//            bool jump;
//        //    Vector2 move;
//        //    SpriteRenderer spriteRenderer;
//            internal Animator animator;
//        //    readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();

//        //    public Bounds Bounds => collider2d.bounds;





//        void UpdateJumpState()
//        {
//            jump = false;
//            switch (jumpState)
//            {
//                case JumpState.PrepareToJump:
//                    jumpState = JumpState.Jumping;
//                    jump = true;
//                    stopJump = false;
//                    break;
//                //case JumpState.Jumping:
//                //    if (!IsGrounded)
//                //    {
//                //        Schedule<PlayerJumped>().player = this;
//                //        jumpState = JumpState.InFlight;
//                //    }
//                //    break;
//                //case JumpState.InFlight:
//                //    if (IsGrounded)
//                //    {
//                //        Schedule<PlayerLanded>().player = this;
//                //        jumpState = JumpState.Landed;
//                //    }
//                //    break;
//                //case JumpState.Landed:
//                //    jumpState = JumpState.Grounded;
//                //    break;
//            }
//        }

//        //protected override void ComputeVelocity()
//        //{
//        //    if (jump && IsGrounded)
//        //    {
//        //        //velocity.y = jumpTakeOffSpeed * model.jumpModifier;
//        //        jump = false;
//        //    }
//        //    else if (stopJump)
//        //    {
//        //        stopJump = false;
//        //        if (velocity.y > 0)
//        //        {
//        //            velocity.y = velocity.y * model.jumpDeceleration;
//        //        }
//        //    }

            

//        //    animator.SetBool("grounded", IsGrounded);
//        //    animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

//        //    //targetVelocity = move * maxSpeed;
//        //}

//        public enum JumpState
//        {
//            Grounded,
//            PrepareToJump,
//            Jumping,
//            InFlight,
//            Landed
//        }
//        //public float speed;
//        //private Rigidbody rb;
//        //private Vector3 velocity = Vector3.zero;
//        [SerializeField] protected float jumpForce;
//        [SerializeField] protected float movementSpeed;

//        protected Rigidbody rb;

//        private float distanceToFeet;

//        public void Awake()
//        {
//            rb = GetComponent<Rigidbody>();
//            distanceToFeet = GetComponent<Collider>().bounds.extents.y;
//            void Awake()
//            {
//                health = GetComponent<Health>();
//                audioSource = GetComponent<AudioSource>();
//                //collider2d = GetComponent<Collider2D>();
//                //spriteRenderer = GetComponent<SpriteRenderer>();
//                animator = GetComponent<Animator>();
//            }
//        }

//        private void Start()
//        {
//            //rb = GetComponent<Rigidbody>();
//        }

//        protected virtual void Update()
//        {
//            //float xMov = Input.GetAxisRaw("Horizontal");
//            //float yMov = Input.GetAxisRaw("Vertical");

//            //Vector3 moveHor = transform.right * xMov;
//            //Vector3 moveVer = transform.forward * yMov;
//            //velocity = (moveHor + moveVer).normalized * speed;


//            //if (Input.GetKeyDown(KeyCode.Escape))
//            //{
//            //    Cursor.lockState = CursorLockMode.None;
//            //    SceneManager.LoadScene(0);
//            //}
//            //if (Input.GetKeyDown(KeyCode.Space))
//            //{

//            //}
//            //if (controlEnabled)
//            //{
//            //    move.x = Input.GetAxis("Horizontal");
//            //    if (jumpState == JumpState.Grounded && Input.GetButtonDown("Jump"))
//            //        jumpState = JumpState.PrepareToJump;
//            //    else if (Input.GetButtonUp("Jump"))
//            //    {
//            //        stopJump = true;
//            //        Schedule<PlayerStopJump>().player = this;
//            //    }
//            //}
//            //else
//            //{
//            //    move.x = 0;
//            //}
//            UpdateJumpState();
//            base.Update();
//            Move();

//        }

//        private void FixedUpdate()
//        {
//            //if (velocity != Vector3.zero)
//            //{
//            //    rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
//            //}
//        }

//        protected virtual void Move()
//        {
//            Vector2 movementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
//            movementInput *= movementSpeed * Time.deltaTime;
//            transform.Translate(new Vector3(movementInput.x, 0f, movementInput.y));
//        }

//        protected virtual void Jump()
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                if (IsGrounded())
//                {
//                    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
//                }
//            }
//        }

//        protected bool IsGrounded()
//        {
//            return Physics.Raycast(transform.position, -Vector3.up, distanceToFeet + 0.1f);
//        }

//    }
//}

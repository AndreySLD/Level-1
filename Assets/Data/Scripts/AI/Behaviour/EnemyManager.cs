using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AS
{
    public class EnemyManager : CharacterManager
    {
        EnemyAnimatorManager enemyAnimatorManager;
        EnemyStats enemyStats;

        public State currentState;
        public CharacterStats currentTarget;
        public NavMeshAgent navmeshAgent;
        public Rigidbody enemyRigidbody;

        public bool isPerfromingAction;
        public bool IsInteracting;

        public float rotationSpeed = 15;
        public float maximumAttackRange = 1.5f;

        [Header("AI")]
        public float detectionRadius = 20;

        public float maximumDetectionAngle = 50;
        public float minimumDetectionAngle = -50;

        public float currentRecoveryTime = 0;

        private void Awake()
        {
            enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
            enemyStats = GetComponent<EnemyStats>();
            navmeshAgent = GetComponentInChildren<NavMeshAgent>();
            enemyRigidbody = GetComponent<Rigidbody>();

            navmeshAgent.enabled = false;
        }
        private void Start()
        {
            enemyRigidbody.isKinematic = false;
        }
        private void Update()
        {
            HandleRecoveryTimer();

            IsInteracting = enemyAnimatorManager.anim.GetBool("IsInteracting");
        }
        private void FixedUpdate()
        {
            HandleStateMachine();

        }
        private void HandleStateMachine()
        {
            if (currentState != null)
            {
                State nextState = currentState.Tick(this, enemyStats, enemyAnimatorManager);

                if (nextState != null)
                {
                    SwitchToNextState(nextState);
                }
            }
        }
        private void SwitchToNextState(State state)
        {
            currentState = state;
        }
        private void HandleRecoveryTimer()
        {
            if (currentRecoveryTime > 0)
            {
                currentRecoveryTime -= Time.deltaTime;
            }

            if (isPerfromingAction)
            {
                if (currentRecoveryTime <= 0)
                {
                    isPerfromingAction = false;
                }
            }
        }
    }
}
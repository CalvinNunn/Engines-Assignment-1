using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        private Command buttonW, buttonA, buttonS, buttonD;
        private bool isReplaying;
        public GameObject player;

        void Start()
        {
            buttonW = new moveForward();
            buttonA = new moveLeft();
            buttonS = new moveBack();
            buttonD = new moveRight();
        }

        void Update()
        {
            if (!isReplaying)
            {
                HandleInput();
            }
            
        }

        void HandleInput()
        {
            if (Input.GetKey("w"))
            {
                buttonW.Execute(player, buttonW);
            }

            if (Input.GetKey("a"))
            {
                buttonA.Execute(player, buttonA);
            }

            if (Input.GetKey("s"))
            {
                buttonS.Execute(player, buttonS);
            }

            if (Input.GetKey("d"))
            {
                buttonD.Execute(player, buttonD);
            }
        }
    }
}
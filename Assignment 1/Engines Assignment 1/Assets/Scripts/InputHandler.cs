﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        private Command buttonW, buttonA, buttonS, buttonD, buttonR;
        private bool isReplaying;
        public GameObject player;
        public static List<Command> oldCommands = new List<Command>();
        public static bool shouldStartReplay;
        private Coroutine replayCoroutine;

        void Start()
        {
            buttonW = new moveForward();
            buttonA = new moveLeft();
            buttonS = new moveBack();
            buttonD = new moveRight();
            buttonR = new UndoCommand();
        }

        void Update()
        {
            if (!isReplaying)
            {
                HandleInput();
            }
            StartReplay();
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
            if (Input.GetKey("r"))
            {
                buttonR.Execute(player, buttonD);
            }
        }

        void StartReplay()
        {
            if (shouldStartReplay && oldCommands.Count > 0)
            {
                shouldStartReplay = false;

                //Stop the coroutine so it starts from the beginning
                if (replayCoroutine != null)
                {
                    StopCoroutine(replayCoroutine);
                }

                //Start the replay
                replayCoroutine = StartCoroutine(replayCommands(player));
            }
        }

        IEnumerator replayCommands(GameObject t)
        {
            isReplaying = true;

            t.transform.position = player.transform.position;

            for(int i = 0; i < oldCommands.Count; i++)
            {
                oldCommands[i].mP(t);
                yield return new WaitForSeconds(0.1f);
            }

            isReplaying = false;
        }
    }
}
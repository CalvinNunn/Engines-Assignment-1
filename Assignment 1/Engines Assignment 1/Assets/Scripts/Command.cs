﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern {
    public abstract class Command
    {
        public abstract void Execute(GameObject p, Command c);

        public virtual void mP(GameObject p) { }

        public virtual void undo(GameObject p) { }
    }
    public class moveForward : Command
    {

        public override void Execute(GameObject p, Command c)
        {
            p.GetComponent<PlayerControl>().moveF();

            mP(p);

            InputHandler.oldCommands.Add(c);
        }
        public override void undo(GameObject p)
        {
            p.transform.Translate(-p.transform.forward * 0.7f);
        }
    }

    public class moveBack : Command
    {
        public override void Execute(GameObject p, Command c)
        {
            p.GetComponent<PlayerControl>().moveB();
            mP(p);
            InputHandler.oldCommands.Add(c);
        }
        public override void undo(GameObject p)
        {
            p.transform.Translate(p.transform.forward * 0.7f);
        }
    }

    public class moveLeft : Command
    {
        public override void Execute(GameObject p, Command c)
        {
            p.GetComponent<PlayerControl>().mL();
            mP(p);
            InputHandler.oldCommands.Add(c);
        }
        public override void undo(GameObject p)
        {
            p.transform.Translate(p.transform.right * 0.7f);
        }
    }

    public class moveRight : Command
    {
        public override void Execute(GameObject p, Command c)
        {
            p.GetComponent<PlayerControl>().mR();
            mP(p);
            InputHandler.oldCommands.Add(c);
        }
        public override void undo(GameObject p)
        {
            p.transform.Translate(-p.transform.right * 0.7f);
        }
    }

    public class jumpCommand : Command
    {
        public override void Execute(GameObject p, Command c)
        {
            p.GetComponent<PlayerControl>().jump();
            mP(p);
            InputHandler.oldCommands.Add(c);
        }
        
    }

    public class UndoCommand : Command
    {
        //Called when we press a key
        public override void Execute(GameObject t, Command command)
        {
            List<Command> oldCommands = InputHandler.oldCommands;

            if (oldCommands.Count > 0)
            {
                Command latestCommand = oldCommands[oldCommands.Count - 1];

                latestCommand.undo(t);

                //Remove the command from the list
                oldCommands.RemoveAt(oldCommands.Count - 1);
            }
        }

        public class ReplayCommand : Command
        {
            public override void Execute(GameObject p, Command command)
            {
                InputHandler.shouldStartReplay = true;
            }
        }

    }
}



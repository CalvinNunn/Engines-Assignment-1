using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(GameObject p, Command c);
    

}
    public class moveForward : Command
    {

        public override void Execute(GameObject p, Command c)
        {
             p.GetComponent<PlayerControl>().moveF();
        }
    }   

    public class moveBack : Command
    {
    public override void Execute(GameObject p, Command c)
    {
        p.GetComponent<PlayerControl>().moveB(); 
    }
}

public class moveLeft : Command
{
    public override void Execute(GameObject p, Command c)
    {
        p.GetComponent<PlayerControl>().mL();
    }
}

public class moveRight : Command
{
    public override void Execute(GameObject p, Command c)
    {
        p.GetComponent<PlayerControl>().mR();
    }
}




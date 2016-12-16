using UnityEngine;
using System.Collections;

namespace Assets.Command
{
    public abstract class PlayerbleCommand : ICommand
    {
        public abstract void Execute();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_PuzzleSolver
{
    public class Node
    {

        private Action nodeAction;  //This contains the last action for achieve the this nodes state.
        private State nodeState;
        private Node parentNode;    //Previous node state.
        private int depth = 0;

        public Node(Action action,State state,Node parent)
        {
            nodeAction = action;
            nodeState = state;
            parentNode = parent;
            if (parent != null) depth = parent.Depth + 1;
           

        }

        public int Depth { get { return depth; } set { depth = value; } }

        public State GetNodeState()
        {
            return nodeState;
        }

        public Node GetParentNode()
        {
            return parentNode;
        }

        public Action GetNodeAction()
        {
            return nodeAction;
        }
    }
}

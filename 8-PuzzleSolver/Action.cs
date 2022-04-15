using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_PuzzleSolver
{
    public struct Action
    {
        public enum ActionTypes {none,left,right,up,down}
        private ActionTypes m_actionType;

        public Action(ActionTypes actionTypes)
        {
            m_actionType = actionTypes;
        }


        public ActionTypes GetActionType()
        {
            return m_actionType;
        }

    }
}

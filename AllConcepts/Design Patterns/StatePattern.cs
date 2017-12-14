using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    /******************************************************************************************************
* Link - http://www.tutorialspoint.com/design_pattern/state_pattern.htm
* In state pattern a class behaviour changes based on its state. In state pattern we create objects to
     * represent various states and a context object whose behaviour varies as its state object changes.
     * Implementation-We are going to create a state interface defining an action and concrete state classes
     * implementing the state interface. Context is a class which carries a state.
* ****************************************************************************************************/

    public interface State
    {
        void GetState();
        void SetContext(Context cntxt);
    }

    public class StartState : State
    {
        public void GetState()
        {
            Console.WriteLine("Start state");
        }

        public void SetContext(Context cntxt)
        {
            cntxt.SetContext(this);
        }
    }

    public class StopState : State
    {
        public void GetState()
        {
            Console.WriteLine("Stop state");
        }

        public void SetContext(Context cntxt)
        {
            cntxt.SetContext(this);
        }
    }
    public class Context
    {
        State _state;
        public void SetContext(State st)
        {
            this._state = st;
        }

        public void Execute()
        {
            _state.GetState();
        }
    }
    class StatePattern
    {
        public void TestStatePattern()
        {
            StartState start = new StartState();
            Context cnt = new Context();
            start.SetContext(cnt);
            cnt.Execute();

            StopState stop = new StopState();
            stop.SetContext(cnt);
            cnt.Execute();
        }
    }
}

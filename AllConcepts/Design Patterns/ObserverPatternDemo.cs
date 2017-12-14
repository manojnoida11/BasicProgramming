using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public abstract class Observer
    {
        protected Subject _subject;
        public abstract void Update();
    }

    public class Subject
    {
        public int state = 0;
        private List<Observer> ObserverList = new List<Observer>();

        public void SetState(int _state)
        {
            this.state = _state;
            NotifyAllObservers();
        }

        public void attach(Observer ob)
        {
            ObserverList.Add(ob);
        }
        private void NotifyAllObservers()
        {
            foreach (Observer obs in ObserverList)
            {
                obs.Update();
            }
        }
    }

    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject _sub)
        {
            this._subject = _sub;
            this._subject.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Number in Binary - " + Convert.ToString(this._subject.state, 2));
        }
    }

    public class OctalObserver : Observer
    {
        public OctalObserver(Subject _sub)
        {
            this._subject = _sub;
            this._subject.attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Number in Octal - " + Convert.ToString(this._subject.state, 8));
        }
    }
    
    public class ObserverPatternDemo
    {
        public void TestObserverPattern()
        {
            Subject sub = new Subject();
            BinaryObserver binOb = new BinaryObserver(sub);
            OctalObserver octOb = new OctalObserver(sub);

            Console.WriteLine("Going to change number to 15");
            sub.SetState(15);

        }
    }
}

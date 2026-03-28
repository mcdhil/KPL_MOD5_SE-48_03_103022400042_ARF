using System;
using System.Collections.Generic;
using System.Text;

namespace KPL_MOD5_SE_48_03_103022400042_ARF

public class MesinKopi
{
    public enum State { OFF, STANBY, BREWING, MAINTENANCE }
    public enum Trigger { POWER_ON, POWER_OFF, START_BREWING, FINISH_BREWING, START_MAINTENANCE, FINISH_MAINTENANCE }

    private State currentState;
    public MesinKopi
    {
        currentState = State.OFF;
    }
    public class Transition
    {
        public State PrevState;
        public State NextState;
        public Trigger Trigger;

        public Transition(State prevState, State nextState, Trigger trigger)
        {
            PrevState = prevState;
            NextState = nextState;
            Trigger = trigger;
        }
    }
    Transition[] transitions = new Transition[]
    {
        new Transition(State.OFF, State.STANBY, Trigger.POWER_ON),
        new Transition(State.STANBY, State.OFF, Trigger.POWER_OFF),
        new Transition(State.STANBY, State.BREWING, Trigger.START_BREWING),
        new Transition(State.BREWING, State.STANBY, Trigger.FINISH_BREWING),
        new Transition(State.STANBY, State.MAINTENANCE, Trigger.START_MAINTENANCE),
        new Transition(State.MAINTENANCE, State.STANBY, Trigger.FINISH_MAINTENANCE)
    };
    private State GetNextState(State prev, Trigger trigger)
    {
        foreach (var transition in transitions)
        {
            if (transition.PrevState == prev && transition.Trigger == trigger)
            {
                return transition.NextState;
            }
        }
        return prev;
    }
 public void TriggerState(Trigger trigger)
    {
        State nextState = GetNextState(currentState, trigger);
        if (nextState == currentState)
        {
            Console.WriteLine($"perubahan state tidak valid");
        }
        else
        {
            Console.WriteLine($"Mesin {FormatStateName(currentState)} berubah menjadi {FormatStateName(nextState)}");
            currentState = nextState;
        }
    }
    private string FormatStateName(State state)
    {
        if(state == State.OFF) return "OFF";
        if(state == State.STANBY) return "STANBY";
        if(state == State.BREWING) return "BREWING";
        if(state == State.MAINTENANCE) return "MAINTENANCE";  
        return state.ToString();
    }
}

using UnityEngine;

public enum MyEnum
{
    IDLE,
    WALK,
    RUN,
    JUMP,
    ATTACK,
}


public class MyStateMachineDemo : MonoBehaviour
{

    private MyEnum _currentState;

    public MyEnum CurrentState { get => _currentState; private set => _currentState = value; }
    private void Start()
    {
    }
    private void Update()
    {
        OnStateUpdate(CurrentState);
    }
    private void OnStateEnter(MyEnum state)
    {
        switch (state)
        {
            case MyEnum.IDLE:
                OnEnterIdle();
                break;
            case MyEnum.WALK:
                OnEnterWalk();
                break;
            case MyEnum.RUN:
                OnEnterRun();
                break;
            case MyEnum.JUMP:
                OnEnterJump();
                break;
            case MyEnum.ATTACK:
                OnEnterAttack();
                break;
            default:
                Debug.LogError("OnStateEnter: Invalid state " + state.ToString());
                break;
        }
    }
    private void OnStateUpdate(MyEnum state)
    {
        switch (state)
        {
            case MyEnum.IDLE:
                OnUpdateIdle();
                break;
            case MyEnum.WALK:
                OnUpdateWalk();
                break;
            case MyEnum.RUN:
                OnUpdateRun();
                break;
            case MyEnum.JUMP:
                OnUpdateJump();
                break;
            case MyEnum.ATTACK:
                OnUpdateAttack();
                break;
            default:
                Debug.LogError("OnStateUpdate: Invalid state " + state.ToString());
                break;
        }
    }
    private void OnStateExit(MyEnum state)
    {
        switch (state)
        {
            case MyEnum.IDLE:
                OnExitIdle();
                break;
            case MyEnum.WALK:
                OnExitWalk();
                break;
            case MyEnum.RUN:
                OnExitRun();
                break;
            case MyEnum.JUMP:
                OnExitJump();
                break;
            case MyEnum.ATTACK:
                OnExitAttack();
                break;
            default:
                Debug.LogError("OnStateExit: Invalid state " + state.ToString());
                break;
        }
    }
    private void TransitionToState(MyEnum toState)
    {
        OnStateExit(CurrentState);
        CurrentState = toState;
        OnStateEnter(toState);
    }
    private void OnEnterIdle()
    {
    }
    private void OnUpdateIdle()
    {
    }
    private void OnExitIdle()
    {
    }
    private void OnEnterWalk()
    {
    }
    private void OnUpdateWalk()
    {
    }
    private void OnExitWalk()
    {
    }
    private void OnEnterRun()
    {
    }
    private void OnUpdateRun()
    {
    }
    private void OnExitRun()
    {
    }
    private void OnEnterJump()
    {
    }
    private void OnUpdateJump()
    {
    }
    private void OnExitJump()
    {
    }
    private void OnEnterAttack()
    {
    }
    private void OnUpdateAttack()
    {
    }
    private void OnExitAttack()
    {
    }
}

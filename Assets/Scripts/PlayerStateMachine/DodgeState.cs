namespace PlayerStateMachine
{
    public class DodgeState : PlayerBaseState
    {
        public DodgeState(PlayerStateMachine ctx, PlayerStateFactory playerStateFactory) : base(ctx, playerStateFactory)
        {
        }

        public override void EnterState()
        {
            _ctx.Animator.SetBool(_ctx.MoveHash, false);
            _ctx.Animator.SetBool(_ctx.DodgeHash, true);
        }

        public override void ExitState()
        {
            
        }

        public override void CheckSwitchState()
        {
            if(_ctx.InputSystem.IsMoving && !_ctx.InputSystem.IsDodging)
                SwitchState(_playerStateFactory.Move());
            else if(!_ctx.InputSystem.IsMoving && !_ctx.InputSystem.IsDodging)
                SwitchState(_playerStateFactory.Idle());
        }

        public override void Update()
        {
            if(_ctx.Animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0)
                _ctx.InputSystem.IsDodging = false;
            CheckSwitchState();
        }

        public override void InitSubState()
        {
            
        }
    }
}
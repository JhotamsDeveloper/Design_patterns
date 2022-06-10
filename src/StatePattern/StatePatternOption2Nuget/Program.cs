

using Stateless;
using StatePatternOption2Nuget.Models;
using StatePatternOption2Nuget.Services;

var stateMachine = new StateMachine<State, Actions>(State.Cesante);
stateMachine.Configure(State.Cesante)
    .Permit(Actions.PasarEntrevista, State.ConEmpleo);
stateMachine.Configure(State.ConEmpleo)
    .Permit(Actions.ObtenerBuenaEvaluacion, State.DeJefe)
    .PermitIf(Actions.JugarLoteria, State.Millionario, () =>
     Loteria.GanarseLoteria
    );
stateMachine.Configure(State.ConEmpleo)
     .Permit(Actions.DeleteFromSinWhereProduccion, State.Cesante);
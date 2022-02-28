using UnityEngine;
using Entitas;


public class TargetingSystem : IExecuteSystem
{
    private IGroup<GameEntity> _mobs;
    private IGroup<GameEntity> _towers;


    public TargetingSystem(Contexts contexts)
    {
        _mobs = contexts.game.GetGroup(GameMatcher.Mob);
        _towers = contexts.game.GetGroup(GameMatcher.TowerDamage);
    }

    public void Execute()
    {
        foreach (var mob in _mobs)
        {
            foreach (var tower in _towers)
            {
                if (tower.HasTarget)
                {
                    if (tower.Target.IsDestroyed || !InRange(tower, tower.Target))
                    {
                        tower.RemoveTarget();
                    }
                }
                else if (InRange(tower, mob))
                {
                    tower.AddTarget(mob);
                }
            }
        }
    }

    private bool InRange(GameEntity tower, GameEntity mob)
    {
        return Vector2.Distance(tower.Position, mob.Position) <= tower.TowerAttackRange.Range;
    }
}
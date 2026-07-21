using Combat.Collision.Manager;
using Combat.Component.Ship;
using Combat.Component.Unit;
using GameDatabase.Enums;
using UnityEngine;

namespace Combat.Collision.Behaviour.Action
{
    public class SlowDownAction : ICollisionAction
    {
        public SlowDownAction(float power, BulletImpactType impactType)
        {
            _impactType = impactType;
            _power = power;
        }

        public void Invoke(IUnit self, IUnit target, CollisionData collisionData, ref Impact selfImpact, ref Impact targetImpact)
        {
            float power;
            if (_impactType == BulletImpactType.DamageOverTime)
            {
                power = _power * collisionData.TimeInterval;
            }
            else
            {
                if (!collisionData.IsNew || !_isAlive)
                    return;

                power = _power;
                _isAlive = _impactType == BulletImpactType.HitAllTargets;
            }

            if (target is IShip ship)
            {
                // Direct velocity dampening: scale velocity by (1 - dampFactor)
                // This avoids the impulse-based push/pull overshoot problem
                var dampFactor = Mathf.Clamp01(power / Mathf.Sqrt(target.Body.Weight));
                var velocity = target.Body.Velocity;
                var angularVelocity = target.Body.AngularVelocity;

                target.Body.Velocity = velocity * (1f - dampFactor);
                target.Body.AngularVelocity = angularVelocity * (1f - dampFactor);
            }
        }

        public void Dispose() {}

        private bool _isAlive = true;
        private readonly float _power;
        private readonly BulletImpactType _impactType;
    }
}

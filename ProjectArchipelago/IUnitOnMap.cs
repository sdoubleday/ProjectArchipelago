    using System;

namespace ProjectArchipelago
{
    public interface IUnitOnMap
    {

        /// <summary>
        /// Destroy this unit, and resolve any relevant triggers.
        /// </summary>
        void DestroyThisUnit();
        /// <summary>
        /// Remove this unit without "Destroyed" triggers.
        /// </summary>
        void RemoveThisUnit();
        /// <summary>
        /// Accepts numeric amount of damage.
        /// </summary>
        /// <param name="DamageAmount"></param>
        /// <returns>Remaining damage capacity</returns>
        int AcceptDamage(int DamageAmount);

    }
}

using System;

namespace ProjectArchipelago
{
    public interface IThingOnMap
    {

        /// <summary>
        /// Destroy this and resolve any relevant triggers.
        /// </summary>
        void DestroyThis();
        /// <summary>
        /// Remove this without "Destroyed" triggers.
        /// </summary>
        void RemoveThis();

    }
}

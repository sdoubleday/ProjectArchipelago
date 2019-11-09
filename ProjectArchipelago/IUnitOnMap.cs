    using System;

namespace ProjectArchipelago
{
    public interface IUnitOnMap
    {
        /// <summary>
        /// Unit's Game Side
        /// </summary>
        /// <returns>Unit's Game Side</returns>
        IGameSide GetMyGameSide();
        /// <summary>
        /// Unit's Game Side
        /// </summary>
        /// <param name="value"></param>
        void SetMyGameSide(IGameSide value);
    }
}

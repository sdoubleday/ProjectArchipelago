
namespace ProjectArchipelago
{
    /// <summary>
    /// All positions on the same Game Side win and
    /// lose together. Probably.
    /// </summary>
    public interface IGameSide
    {
        /// <summary>
        /// The Game Side's name.
        /// </summary>
        /// <returns>Game Side's name</returns>
        string GetName();
        /// <summary>
        /// The Game Side's name.
        /// </summary>
        /// <param name="value"></param>
        void SetName(string value);
    }
}

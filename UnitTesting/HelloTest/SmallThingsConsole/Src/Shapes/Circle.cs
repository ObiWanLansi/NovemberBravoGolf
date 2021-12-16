


namespace SmallThings.Shapes
{
    /// <summary>
    /// Defines an simple circle and some functions for automatic calculations.
    /// </summary>
    /// <seealso cref="https://de.wikipedia.org/wiki/Kreis"/>
    public class Circle
    {
        /// <summary>
        /// The radius in cm.
        /// </summary>
        private readonly uint radius_cm;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius_cm">The radius in cm.</param>
        public Circle( uint radius_cm )
        {
            this.radius_cm = radius_cm;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        #region Berechnungsmethoden

        /// <summary>
        /// Gets the radius in cm.
        /// </summary>
        /// <returns></returns>
        public uint GetRadius()
        {
            return this.radius_cm;
        }


        /// <summary>
        /// Gets the durchmesser in cm.
        /// </summary>
        /// <returns></returns>
        public uint GetDurchmesser()
        {
            return this.radius_cm * 2;
        }


        /// <summary>
        /// Gets the umfang in cm.
        /// </summary>
        /// <returns></returns>
        public double GetUmfang()
        {
            // Definitiv ein Bug ;-)
            return 0;
        }

        #endregion

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Converts to an string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"{this.radius_cm} cm";
    }
}

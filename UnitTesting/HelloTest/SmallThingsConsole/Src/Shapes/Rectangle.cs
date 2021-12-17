


namespace SmallThings.Shapes
{
    /// <summary>
    /// An simple reactangle for demonstration purpose.
    /// </summary>
    public class Rectangle
    {
        private readonly uint x_mm;

        private readonly uint y_mm;

        private readonly uint width_mm;

        private readonly uint height_mm;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="x_mm">The x mm.</param>
        /// <param name="y_mm">The y mm.</param>
        /// <param name="width_mm">The width mm.</param>
        /// <param name="height_mm">The height mm.</param>
        public Rectangle( uint x_mm, uint y_mm, uint width_mm, uint height_mm )
        {
            this.x_mm = x_mm;
            this.y_mm = y_mm;
            this.width_mm = width_mm;
            this.height_mm = height_mm;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        #region Berechnungsmethoden

        /// <summary>
        /// Gets the umfang in cm.
        /// </summary>
        /// <returns></returns>
        public uint GetUmfang()
        {
            return ( this.width_mm * 2 ) + ( this.height_mm * 2 );
        }


        /// <summary>
        /// Gets the flaeche in cm².
        /// </summary>
        /// <returns></returns>
        public uint GetFlaeche()
        {
            return this.width_mm * this.height_mm;
        }

        #endregion

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"{this.x_mm}/{this.y_mm} ({this.width_mm}/{this.height_mm})";
    }
}

using DotNetCoords.Ellipsoid;

namespace DotNetCoords.Datum.NAD27
{
  /// <summary>
  /// Class representing the NAD27 (Bahamas) datum.
  /// </summary>
  public sealed class NAD27BahamasDatum : Datum<NAD27BahamasDatum>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="NAD27BahamasDatum"/> class.
    /// </summary>
    public NAD27BahamasDatum() 
    {
      name = "North American Datum 1927 (NAD27) - Bahamas";
      ellipsoid = Clarke1866Ellipsoid.Instance;
      dx = -4.0;
      dy = 154.0;
      dz = 178.0;
      ds = 0.0;
      rx = 0.0;
      ry = 0.0;
      rz = 0.0;
    }
  }
}

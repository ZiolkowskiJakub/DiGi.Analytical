using DiGi.Analytical.Classes;

namespace DiGi.Analytical.Delegates
{
    /// <summary>
    /// Represents the method that will handle the coplanar face split event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="CoplanarFaceSplitEventArgs"/> containing the event data.</param>
    public delegate void CoplanarFaceSplitEventHandler(object sender, CoplanarFaceSplitEventArgs e);
}
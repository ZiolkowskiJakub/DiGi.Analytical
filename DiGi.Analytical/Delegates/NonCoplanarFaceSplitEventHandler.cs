using DiGi.Analytical.Classes;

namespace DiGi.Analytical.Delegates
{
    /// <summary>
    /// Represents the method that will handle the non-coplanar face split event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="NonCoplanarFaceSplitEventArgs"/> containing the event data.</param>
    public delegate void NonCoplanarFaceSplitEventHandler(object sender, NonCoplanarFaceSplitEventArgs e);
}
using DiGi.Analytical.Classes;

namespace DiGi.Analytical.Delegates
{
    /// <summary>
    /// Represents the method that will handle the face split event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="FaceSplitEventArgs"/> containing the event data.</param>
    public delegate void FaceSplitEventHandler(object sender, FaceSplitEventArgs e);
}
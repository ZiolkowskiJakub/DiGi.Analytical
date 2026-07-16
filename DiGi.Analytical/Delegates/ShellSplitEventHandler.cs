using DiGi.Analytical.Classes;

namespace DiGi.Analytical.Delegates
{
    /// <summary>
    /// Represents the method that will handle the shell split event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="ShellSplitEventArgs"/> containing the event data.</param>
    public delegate void ShellSplitEventHandler(object sender, ShellSplitEventArgs e);
}
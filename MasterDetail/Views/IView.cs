namespace MvvmSample.Views
{
    public interface IView
    {
        //
        // Summary:
        // Manually closes a System.Windows.Window.
        void Close();

        //
        // Summary:
        //     Opens a window and returns only when the newly opened window is closed.
        //
        // Returns:
        //     A System.Nullable`1 value of type System.Boolean that specifies whether the activity
        //     was accepted (true) or canceled (false). The return value is the value of the
        //     System.Windows.Window.DialogResult property before a window closes.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     System.Windows.Window.ShowDialog is called on a System.Windows.Window that is
        //     visible-or-System.Windows.Window.ShowDialog is called on a visible System.Windows.Window
        //     that was opened by calling System.Windows.Window.ShowDialog.
        //
        //   T:System.InvalidOperationException:
        //     System.Windows.Window.ShowDialog is called on a window that is closing (System.Windows.Window.Closing)
        //     or has been closed (System.Windows.Window.Closed).
        bool? ShowDialog();

        //
        // Summary:
        //     Opens a window and returns without waiting for the newly opened window to close.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     System.Windows.Window.Show is called on a window that is closing (System.Windows.Window.Closing)
        //     or has been closed (System.Windows.Window.Closed).
        void Show();
    }
}

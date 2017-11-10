using System;

namespace XamarinDecouplingDemo
{
    interface IRequireDialogInteraction
    {
        void OnDialogConfirmation(object sender, EventArgs e);
        void OnDialogCancellation(object sender, EventArgs e);
    }
}

using System.Drawing;

namespace ActionNotifications.Models.Contracts
{
    public interface IActionNotification
    {
        string Title { get; set; }
        string Message { get; set; }
        Color TextColor { get; set; }
    }
}
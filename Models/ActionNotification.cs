using ActionNotifications.Models.Contracts;
using System.Drawing;

namespace ActionNotifications.Models
{
    public class ActionNotification : IActionNotification
    {
        private string _Title;
        private string _Message;
        private Color _TextColor;

        public string Title { 
            get {return _Title;} 
            set {_Title = value;} 
            }
        public string Message { 
            get {return _Message;} 
            set {_Message = value;} 
            }

        public Color TextColor {
            get { return _TextColor; }
            set { _TextColor = value; }
        }
    }
}
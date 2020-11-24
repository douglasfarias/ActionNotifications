using ActionNotifications.Models.Contracts;
namespace ActionNotifications.Models
{
    public class ActionNotification : IActionNotification
    {
        private string _Title;
        private string _Message;

        public string Title { 
            get {return _Title;} 
            set {_Title = value;} 
            }
        public string Message { 
            get {return _Message;} 
            set {_Message = value;} 
            }
    }
}
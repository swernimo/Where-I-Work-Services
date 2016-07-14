using Microsoft.Azure.Mobile.Server;

namespace where_I_workService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}
using System;
using Microsoft.Azure.Mobile.Server;

namespace where_I_workService.DataObjects
{
    public class Favorite : EntityData
    {
        public Guid UserID { get; set; }

        public Guid BusinessID { get; set; }
    }
}
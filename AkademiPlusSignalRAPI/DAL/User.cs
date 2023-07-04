using System.Collections.Generic;

namespace AkademiPlusSignalRAPI.DAL
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public Room Room { get; set; }
    }
}

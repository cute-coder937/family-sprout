﻿using FamilySprout.Core.Utils;

namespace FamilySprout.Core.Model
{
    public class ParentModel
    {
        public long id { get; set; }
        public long famId { get; set; }
        public string name { get; set; }
        public string contactNumber { get; set; }
        public string bday { get; set; }
        public string birthPlace { get; set; }
        public string baptism { get; set; }
        public string hc { get; set; }
        public string matrimony { get; set; }
        public string obitus { get; set; }
        public int role { get; set; }
        public string createdBy { get; set; }
        public string dateCreated { get; set; }
        public bool isDeleted { get; set; }

        public ParentModel()
        {
            createdBy = SessionManager.CurrentUser.username;
            dateCreated = DateUtils.GetCreateDate();
        }
    }
}

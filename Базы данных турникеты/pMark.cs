//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Базы_данных_турникеты
{
    using System;
    using System.Collections.Generic;
    
    public partial class pMark
    {
        public int ID { get; set; }
        public int Gtype { get; set; }
        public Nullable<int> GTypeCodeAdd { get; set; }
        public int Config { get; set; }
        public string CodeP { get; set; }
        public string CodePAdd { get; set; }
        public Nullable<int> Status { get; set; }
        public int Owner { get; set; }
        public string OwnerName { get; set; }
        public Nullable<int> GrStatus { get; set; }
        public int GroupID { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> Finish { get; set; }
        public Nullable<int> IndexForContactId { get; set; }
        public string Comment { get; set; }
        public string Login { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Workstation { get; set; }
        public string fingertemplate { get; set; }
    }
}

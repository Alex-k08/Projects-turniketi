﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gimnazia1Entities3 : DbContext
    {
        public Gimnazia1Entities3()
            : base("name=Gimnazia1Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<pList> pList { get; set; }
        public virtual DbSet<pLogData> pLogData { get; set; }
        public virtual DbSet<pMark> pMark { get; set; }
    }
}

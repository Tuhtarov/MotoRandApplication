//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotoRandApplication.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administrators
    {
        public int IdAdministrator { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public int IdAccount { get; set; }
    
        public virtual Accounts Accounts { get; set; }
    }
}

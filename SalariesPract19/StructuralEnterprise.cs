//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalariesPract19
{
    using System;
    using System.Collections.Generic;
    
    public partial class StructuralEnterprise
    {
        public string StructuralUnit { get; set; }
        public Nullable<int> Department { get; set; }
    
        public virtual DepartmentHandbook DepartmentHandbook { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountFriends
    {
        public int Id_AccountFriends { get; set; }
        public Nullable<int> Id_Friend { get; set; }
        public Nullable<int> Id_Account { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Friend Friend { get; set; }
    }
}

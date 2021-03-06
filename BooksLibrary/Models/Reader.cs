//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Reader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reader()
        {
            this.Extraditions = new HashSet<Extradition>();
        }
    
        public int id { get; set; }
        [Display(Name = "Фамилия")]
        public string last_name { get; set; }
        [Display(Name = "Имя")]
        public string name { get; set; }
        [Display(Name = "Отчество")]
        public string middle_name { get; set; }
        [Display(Name = "Возраст")]
        public short age { get; set; }
        [Display(Name = "Адрес")]
        public string address { get; set; }
        [Display(Name = "Телефон")]
        public string phone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Extradition> Extraditions { get; set; }
    }
}

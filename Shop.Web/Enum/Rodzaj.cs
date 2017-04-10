using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Web.Enum
{
    public enum Rodzaj
    {
        Audiobook=0,
        [Display(Name="E-book")]
        Ebook=1
    }
}
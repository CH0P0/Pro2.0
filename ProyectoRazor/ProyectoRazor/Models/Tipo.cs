﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ProyectoRazor.Models
{
    public partial class Tipo
    {
        public Tipo()
        {
            DiscoTipo = new HashSet<DiscoTipo>();
        }

        public int IdTipo { get; set; }
        public string Tipo1 { get; set; }

        public virtual ICollection<DiscoTipo> DiscoTipo { get; set; }
    }
}
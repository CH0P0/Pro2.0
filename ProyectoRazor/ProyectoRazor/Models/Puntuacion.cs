﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ProyectoRazor.Models
{
    public partial class Puntuacion
    {
        public int Id { get; set; }
        public int? Idcliente { get; set; }
        public int? Iddisco { get; set; }
        public int? Puntuacion1 { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; }
        public virtual Disco IddiscoNavigation { get; set; }
    }
}
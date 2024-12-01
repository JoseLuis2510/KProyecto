﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KDataBaseEntities : DbContext
    {
        public KDataBaseEntities()
            : base("name=KDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tCarrito> tCarrito { get; set; }
        public virtual DbSet<tError> tError { get; set; }
        public virtual DbSet<tProducto> tProducto { get; set; }
        public virtual DbSet<tRol> tRol { get; set; }
        public virtual DbSet<tUsuario> tUsuario { get; set; }
    
        public virtual int ActualizarContrasenna(string contrasennaTemp, Nullable<bool> tieneContrasennaTemp, Nullable<System.DateTime> fechaVencimientoTemp, Nullable<long> consecutivo)
        {
            var contrasennaTempParameter = contrasennaTemp != null ?
                new ObjectParameter("ContrasennaTemp", contrasennaTemp) :
                new ObjectParameter("ContrasennaTemp", typeof(string));
    
            var tieneContrasennaTempParameter = tieneContrasennaTemp.HasValue ?
                new ObjectParameter("TieneContrasennaTemp", tieneContrasennaTemp) :
                new ObjectParameter("TieneContrasennaTemp", typeof(bool));
    
            var fechaVencimientoTempParameter = fechaVencimientoTemp.HasValue ?
                new ObjectParameter("FechaVencimientoTemp", fechaVencimientoTemp) :
                new ObjectParameter("FechaVencimientoTemp", typeof(System.DateTime));
    
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarContrasenna", contrasennaTempParameter, tieneContrasennaTempParameter, fechaVencimientoTempParameter, consecutivoParameter);
        }
    
        public virtual int ActualizarPerfil(string identificacion, string nombre, string correoElectronico, Nullable<long> consecutivo, Nullable<int> consecutivoRol)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("CorreoElectronico", correoElectronico) :
                new ObjectParameter("CorreoElectronico", typeof(string));
    
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(long));
    
            var consecutivoRolParameter = consecutivoRol.HasValue ?
                new ObjectParameter("ConsecutivoRol", consecutivoRol) :
                new ObjectParameter("ConsecutivoRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarPerfil", identificacionParameter, nombreParameter, correoElectronicoParameter, consecutivoParameter, consecutivoRolParameter);
        }
    
        public virtual ObjectResult<ConsultarCarritoUsuario_Result> ConsultarCarritoUsuario(Nullable<long> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarCarritoUsuario_Result>("ConsultarCarritoUsuario", consecutivoParameter);
        }
    
        public virtual ObjectResult<InicioSesion_Result> InicioSesion(string identificacion, string contrasenna)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InicioSesion_Result>("InicioSesion", identificacionParameter, contrasennaParameter);
        }
    
        public virtual int RegistroUsuario(string identificacion, string nombre, string correoElectronico, string contrasenna)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("CorreoElectronico", correoElectronico) :
                new ObjectParameter("CorreoElectronico", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistroUsuario", identificacionParameter, nombreParameter, correoElectronicoParameter, contrasennaParameter);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDatos
{
    public class CD_Medico
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMedicos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Crear(string nombre, int edad, string genero, string especialidad, string codigo, string contraMedico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@especialidad", especialidad);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@contraMedico", contraMedico);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, int edad, string genero, string especialidad, string codigo, string contraMedico, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@especialidad", especialidad);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@contraMedico", contraMedico);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMedico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}

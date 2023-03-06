﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using System.Windows;
using MySqlConnector;

namespace AccDatos
{
    public class AccesoDatos
    {
        MySqlConnection conn;
        MySqlCommand commandDatabase;
        string connectionString = "Server=127.0.0.1;" +
                                "Port=3306;" +
                                "Database=sakila;" +
                                "Uid=usuarioNormal;" +
                                "Pwd=1234;";
        
        public AccesoDatos()
        {
            conn = new MySqlConnection(connectionString);
        }
        public void EstablecerConexion()
        {
            conn.Open();
        }
        public void CerrarConexion()
        {
            conn.Close();
        }
        public ObservableCollection<string> Q_ReadActors()
        {
            try
            {
                EstablecerConexion();
                string query = "SELECT * FROM actor;";
                commandDatabase = new MySqlCommand(query, conn);
                
                MySqlDataReader reader;
                commandDatabase.CommandTimeout = 60;
                ObservableCollection<string> nombres_actores = new ObservableCollection<string>();

            
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Hacer algo con cada fila obtenida
                        nombres_actores.Add(reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                // Cerrar la conexión
                CerrarConexion();
                return nombres_actores;
            }
            catch (MySqlException ex)
            {
                // Mostrar excepción tipo MySQL
                MessageBox.Show(ex.Message);
                CerrarConexion();
                return null;
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
                CerrarConexion();
                return null;
            }
        }   

        public void SP_UpdateActor(int id_actor, string nuevoApellido)
        {
            try
            {
                EstablecerConexion();

                //Preparar la llamada al Procedimiento Almacenado
                commandDatabase = new MySqlCommand("CambiarApellidoActor", conn);
                commandDatabase.CommandType = CommandType.StoredProcedure;
                commandDatabase.Parameters.AddWithValue("_nuevoApellido", nuevoApellido);
                commandDatabase.Parameters.AddWithValue("_id_actor", id_actor);

                //Lanzar un Procedimiento Almacenado
                commandDatabase.ExecuteNonQuery();

                CerrarConexion();
               
            }
            catch (MySqlException ex)
            {
                // Mostrar excepción tipo MySQL
                MessageBox.Show(ex.Message);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
                CerrarConexion();
            }
        }

        public DataSet SP_StaffDetail(int id_staff)
        {
            DataSet data = new DataSet();
            MySqlDataReader dbData; 
            try
            {
                EstablecerConexion();

                //Preparar la llamada al Procedimiento Almacenado
                commandDatabase = new MySqlCommand("VerDatosEmpleado", conn);
                commandDatabase.CommandType = CommandType.StoredProcedure;
                commandDatabase.Parameters.AddWithValue("_id_empleado", id_staff);

                //Lanzar un Procedimiento Almacenado
                dbData = commandDatabase.ExecuteReader();
                //Extraer en un DataSet lo leído en la Base de Datos.
                DataTable dt = new DataTable();
                dt.Load(dbData);
                data.Tables.Add(dt);

                CerrarConexion();
                return data;
            }
            catch (MySqlException ex)
            {
                // Mostrar excepción tipo MySQL
                MessageBox.Show(ex.Message);
                CerrarConexion();
                return null;
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
                CerrarConexion();
                return null;
            }


        }

        public int SP_AddStaff(string nombre, string apellido, string mail, string usuario, string pass)
        {
            try
            {
                EstablecerConexion();

                //Preparar la llamada al Procedimiento Almacenado
                commandDatabase = new MySqlCommand("AltaEmpleado_v2", conn);
                commandDatabase.CommandType = CommandType.StoredProcedure;
                commandDatabase.Parameters.AddWithValue("@_nombre", nombre);
                commandDatabase.Parameters.AddWithValue("@_apellido", apellido);
                commandDatabase.Parameters.AddWithValue("@_email", mail);
                commandDatabase.Parameters.AddWithValue("@_usuario", usuario);
                commandDatabase.Parameters.AddWithValue("@_password", pass);

                commandDatabase.Parameters.Add("@_resultado", MySqlDbType.Int32);
                commandDatabase.Parameters["@_resultado"].Direction = ParameterDirection.Output;

                //Lanzar un Procedimiento Almacenado
                commandDatabase.ExecuteNonQuery();

                int resultado = int.Parse(commandDatabase.Parameters["@_resultado"].Value.ToString());

                CerrarConexion();
                return resultado;
            }
            catch (MySqlException ex)
            {
                // Mostrar excepción tipo MySQL
                MessageBox.Show(ex.Message);
                CerrarConexion();

                return -99;
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
                CerrarConexion();
                return -98;
            }
        }
        public int SP_Login(string usuario, string pass)
        {
            try
            {
                EstablecerConexion();

                //Preparar la llamada al Procedimiento Almacenado
                commandDatabase = new MySqlCommand("LoginEmpleado", conn);
                commandDatabase.CommandType = CommandType.StoredProcedure;
                commandDatabase.Parameters.AddWithValue("@_usuario", usuario);
                commandDatabase.Parameters.AddWithValue("@_password", pass);

                commandDatabase.Parameters.Add("@_resultado", MySqlDbType.Int32);
                commandDatabase.Parameters["@_resultado"].Direction = ParameterDirection.Output;

                //Lanzar un Procedimiento Almacenado
                commandDatabase.ExecuteNonQuery();

                int resultado = int.Parse(commandDatabase.Parameters["@_resultado"].Value.ToString());

                CerrarConexion();
                return resultado;
            }
            catch (MySqlException ex)
            {
                // Mostrar excepción tipo MySQL
                MessageBox.Show(ex.Message);
                CerrarConexion();

                return -99;
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
                CerrarConexion();
                return -98;
            }
        }


    }
}

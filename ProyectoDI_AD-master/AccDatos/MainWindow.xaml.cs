using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccDatos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DummyManager manager;
        public MainWindow()
        {
            InitializeComponent();
            manager = new DummyManager();

            DataContext = manager;

            OcultarTodo();
            MostrarLogIn();

        }
        void OcultarTodo()
        {
            // Este sp hay que crearlo
            sp_FormRegistro.Visibility = Visibility.Collapsed;
            sp_LOGIN.Visibility = Visibility.Collapsed;
        }
        void MostrarLogIn()
        {
            sp_LOGIN.Visibility = Visibility.Visible;
        }
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    manager.CambiarApellidoActor(int.Parse(tb_idActor.Text), tb_nuevoApellido.Text);
        //}

        //private void Button_Click_DatosStaff(object sender, RoutedEventArgs e)
        //{
        //    manager.VerDatosEmpleado(1); //  Esta comentado en el dummy manager
        //}
        // Hay que crear los textBlock
        private void Button_Click_Alta(object sender, RoutedEventArgs e)
        {
            if (pb_pass.Password == pb_pass.Password) // tb_passEmpleadoConfirm
            {

                // Crear en el registro los textbox y textblock que tocan
                manager.AltaUsuario(tb_nombre.Text,
                                     tb_apellido.Text,
                                     tb_mail.Text,
                                     //  int.Parse(tb_tiendaEmpleado.Text),
                                     tb_usuario_Alta.Text, // Este 

                                     pb_pass_Alta.Password // Y este estan cambiados son los mismo pero otro textbox o password box

                                     );
            }
            else
            {
                MessageBox.Show("La contraseña no coincide con el campo de confrimación. Vuelva a intentarlo");
            }
        }

        private void bt_registro_Click(object sender, RoutedEventArgs e)
        {
            sp_LOGIN.Visibility = Visibility.Collapsed;
            sp_FormRegistro.Visibility = Visibility.Visible; // El stack panel lo tengo que crear 
        }

        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            manager.Login(tb_usuario.Text, pb_pass.Password);
        }

        private void bt_usuarioAnonimo_Click(object sender, RoutedEventArgs e)
        {
            sp_PreparacionSimulacion.Visibility = Visibility.Visible; // Aqui se ve tambien el Boton Cerrar Sesión
            sp_LOGIN.Visibility = Visibility.Collapsed;
        }
        private void bt_iniciarTablero_Click(object sender, RoutedEventArgs e)
        {
            sp_Tablero.Visibility = Visibility.Visible;
        }
        private void bt_Avanzar1_Click(object sender, RoutedEventArgs e)
        {
            sp_Tablero.Visibility = Visibility.Visible;
        }
        private void bt_Cerrar_Sesion(object sender, RoutedEventArgs e)
        {
            sp_Tablero.Visibility = Visibility.Visible;
        }
        private void bt_Registrarse_Click(object sender, RoutedEventArgs e)
        {
            sp_FormRegistro.Visibility = Visibility.Visible;
        }
        private void bt_configuracion(object sender, RoutedEventArgs e)
        {
            sp_Configuracion.Visibility = Visibility.Visible;
            sp_FormRegistro.Visibility = Visibility.Collapsed;
            sp_LOGIN.Visibility = Visibility.Collapsed;
            sp_PreparacionSimulacion.Visibility = Visibility.Collapsed;
            sp_Tablero.Visibility = Visibility.Collapsed;
           // sp_Musica.Visibility = Visibility.Collapsed;
        }
        private void sp_Musica(object sender, RoutedEventArgs e)
        {
            sp_Configuracion.Visibility = Visibility.Visible;
            sp_LOGIN.Visibility = Visibility.Collapsed;
            sp_FormRegistro.Visibility = Visibility.Collapsed;
            sp_PreparacionSimulacion.Visibility = Visibility.Collapsed;
            sp_Tablero.Visibility = Visibility.Collapsed;

        }
    }
}

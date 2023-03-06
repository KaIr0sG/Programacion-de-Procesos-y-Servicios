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
using System.Windows.Media.Animation;
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
            //Las funciones para los void

            OcultarTodo();
            MostrarLogIn();

        }
        //Aqui ocultamos todo 
        void OcultarTodo()
        {
            sp_FormRegistro.Visibility = Visibility.Collapsed;
            sp_LOGIN.Visibility = Visibility.Collapsed;
            sp_PreparacionSimulacion.Visibility = Visibility.Collapsed;
        }
        //Aqui mostramos el login 
        void MostrarLogIn()
        {
            sp_LOGIN.Visibility = Visibility.Visible;
            // sp_Inicio.Visibility = Visibility.Collapsed;

        }
        //Aqui mostramos el registro
        void MostrarRegistro()
        {
            sp_FormRegistro.Visibility = Visibility.Visible;
            sp_LOGIN.Visibility = Visibility.Collapsed;
        }
        // Nos enseña la simulacion y nos oculta el login y el registro
        private void MostrarPreparacionSimulacion()
        {
            sp_PreparacionSimulacion.Visibility = Visibility.Visible;
            sp_FormRegistro.Visibility = Visibility.Collapsed;
            sp_LOGIN.Visibility = Visibility.Collapsed;
            // sp_ivitado.Visibility = Visibility.Collapsed;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    manager.CambiarApellidoActor(int.Parse(tb_idActor.Text), tb_nuevoApellido.Text);
        //}

        private void Button_Click_DatosStaff(object sender, RoutedEventArgs e)
        {
            manager.VerDatosEmpleado(1);
        }
        // Nos confirma si el usuario se ha dado de alta o no
        private void Button_Click_Alta(object sender, RoutedEventArgs e)
        {
            if (tb_pass.Password == tb_passConfirm.Password)
            {


                manager.AltaEmpleado(tb_nombre.Text,
                                     tb_apellido.Text,
                                     tb_mail.Text,
                                     //int.Parse(tb_tiendaEmpleado.Text),
                                     tb_usuario.Text,
                                     tb_pass.Password

                                     );
            }
            else
            {
                MessageBox.Show("La contraseña no coincide con el campo de confrimación. Vuelva a intentarlo");
            }
        }
        // Nos oculta todo y nos muestra el registro
        private void bt_registro_Click(object sender, RoutedEventArgs e)
        {
            OcultarTodo();
            MostrarRegistro();
        }

        //  Los TextBox que tenemos, nos los mandamos al manager que va a la BBDD
        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            manager.Login(tb_usuario.Text, pb_pass.Password);
        }

        // Inicio de invitado
        private void bt_usuarioAnonimo_Click(object sender, RoutedEventArgs e)
        {
            OcultarTodo();
            MostrarPreparacionSimulacion();
        }
       // Al iniciar el tablero nos dara el tablero que indicamos 
        private void bt_iniciarTablero_Click(object sender, RoutedEventArgs e)
        {
            manager.CargarDatosNuevaSimulacion(int.Parse(tb_filas.Text),
                                               int.Parse(tb_columnas.Text),
                                               double.Parse(tb_P.Text),
                                               double.Parse(tb_Q.Text));

            sp_Tablero.Children.Clear();

            sp_Tablero.Children.Add(manager.PintarTableroModelo());

            sp_Tablero.Visibility = Visibility.Visible;

        }
        // Boton avanzar
        private void Avanzar1_Click(object sender, RoutedEventArgs e)
        {
            manager.Avanzar1();

            sp_Tablero.Children.Clear();
            sp_Tablero.Children.Add(manager.PintarTableroModelo());
        }
        // Ocultamos el tablero y la simulacion y enseñamos el login
        private void bt_Cerrar_Sesion(object sender, RoutedEventArgs e)
        {
            sp_Tablero.Visibility = Visibility.Collapsed;
            sp_PreparacionSimulacion.Visibility = Visibility.Collapsed;
            sp_LOGIN.Visibility = Visibility.Visible;
        }
        // Ocultamos el Login y mostramos el registro
        private void bt_Registrarse_Click(object sender, RoutedEventArgs e)
        {
            sp_FormRegistro.Visibility = Visibility.Visible;
            sp_LOGIN.Visibility = Visibility.Collapsed;
        }

        public static class AnimationHelper
        {
            private static void AnimateWidth(DependencyObject target, double from, double to)
            {
                var WidthAnimation = new DoubleAnimation
                {
                    From = 80,
                    To = 120,
                    Duration = TimeSpan.FromSeconds(2)
                };

                Storyboard.SetTarget(WidthAnimation, target);
                Storyboard.SetTargetProperty(WidthAnimation, new PropertyPath("Width"));
               

                var storyboard = new Storyboard();
                storyboard.Children.Add(WidthAnimation);
                storyboard.Begin();
            }

            /// <summary>
            /// Fades in the given dependency object.
            /// </summary>
            /// <param name="target">The target dependency object to fade in.</param>
            public static void FadeIn(DependencyObject target)
            {
                AnimateWidth(target, 0, 1);
            }
        }

    }
    }
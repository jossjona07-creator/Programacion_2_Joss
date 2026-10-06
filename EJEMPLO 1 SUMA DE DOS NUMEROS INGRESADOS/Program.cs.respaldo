using System;
using System.Windows.Forms;

namespace EJEMPLO_1_SUMA_DE_DOS_NUMEROS_INGRESADOS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form menu = new Form();
            menu.Text = "SELECCIONAR EJERCICIO";
            menu.Width = 400;
            menu.Height = 300;
            menu.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Seleccione el ejercicio:";
            titulo.AutoSize = true;
            titulo.Left = 110;
            titulo.Top = 30;

            Button botonRegistro = new Button();
            botonRegistro.Text = "1 - REGISTRO";
            botonRegistro.Width = 150;
            botonRegistro.Left = 120;
            botonRegistro.Top = 70;

            Button botonSuma = new Button();
            botonSuma.Text = "2 - SUMA";
            botonSuma.Width = 150;
            botonSuma.Left = 120;
            botonSuma.Top = 120;

            Button botonMultiplicacion = new Button();
            botonMultiplicacion.Text = "3 - MULTIPLICACIÓN";
            botonMultiplicacion.Width = 150;
            botonMultiplicacion.Left = 120;
            botonMultiplicacion.Top = 170;

            botonRegistro.Click += (sender, e) =>
            {
                frmRegistro ventana = new frmRegistro();
                ventana.ShowDialog();
            };

            botonSuma.Click += (sender, e) =>
            {
                Form ventana = new Form();
                ventana.Text = "Suma de dos números";
                ventana.Width = 500;
                ventana.Height = 350;

                suma_clase_joss suma = new suma_clase_joss();
                suma.Dock = DockStyle.Fill;

                ventana.Controls.Add(suma);
                ventana.ShowDialog();
            };

            botonMultiplicacion.Click += (sender, e) =>
            {
                Form ventana = new Form();
                ventana.Text = "Multiplicación de dos números";
                ventana.Width = 500;
                ventana.Height = 350;

                CLASE_MULTIPLICACION_JOSS multiplicacion = new CLASE_MULTIPLICACION_JOSS();
                multiplicacion.Dock = DockStyle.Fill;

                ventana.Controls.Add(multiplicacion);
                ventana.ShowDialog();
            };

            menu.Controls.Add(titulo);
            menu.Controls.Add(botonRegistro);
            menu.Controls.Add(botonSuma);
            menu.Controls.Add(botonMultiplicacion);

            Application.Run(menu);
        }
    }
}

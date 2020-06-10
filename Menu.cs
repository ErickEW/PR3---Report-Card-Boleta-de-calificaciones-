using System;
using System.Collections.Generic;

namespace Boleta
{
    class Menu
    {
        private const int MAIN_MENU_EXIT_OPTION = 9;
        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 9 });
        public List<int> seleccionarMateria = new List<int>(new int[] { 1, 2, 3 });
        public Alumnos alumnoIngresado = null;
        public Materia materiaIngresada = null;


        private void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("Bienvenid@ a Palmore");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions()
        {
            System.Console.WriteLine("1) Ingresar Alumn@");
            System.Console.WriteLine("2) Ingresar Materia");
            System.Console.WriteLine("3) Ingresar Calificaciones y sacar promedio");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage()
        {
            System.Console.WriteLine("Adios");
        }

        public int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

       public void NombreAlumno()
        {
            System.Console.WriteLine("Escribe el nombre del Alumno");
            string nombreIngresar = Convert.ToString(Console.ReadLine());
        }

       private void OpcionesMateria()
        {
            System.Console.WriteLine("Selecciona la Materia a evaluar");
            System.Console.WriteLine("1) Calculo Diferencial");
            System.Console.WriteLine("2) Programación");
            System.Console.WriteLine("3) Publicidad");

        }

        public void elegirMateria()
        {
            int selectedOption = 0;

            OpcionesMateria();

            selectedOption = RequestOption(seleccionarMateria);

            switch (selectedOption)
            {
                case 1:
                    materiaIngresada = new Materia("Calculo Diferencial");
                    break;
                case 2:
                    materiaIngresada = new Materia("Programación");
                    break;
                case 3:
                    materiaIngresada = new Materia("Publicidad");
                    break;

            }
        }

        public void ingresarCalificaciones()
        {
            System.Console.WriteLine("Ingresa la calificación del 1er parcial");
            int calificacion1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingresa la calificación del 2do parcial");
            int calificacion2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingresa la calificación del 3er parcial");
            int calificacion3 = Convert.ToInt32(Console.ReadLine());
            int resultado = (calificacion1 + calificacion2 + calificacion3);
            Console.WriteLine("El promedio es: " + resultado/3);
        }






        public void Display()
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1:
                        NombreAlumno();
                        break;

                    case 2:
                        elegirMateria();
                        break;

                    case 3:
                        ingresarCalificaciones();
                        break;

                }
            }

            DisplayByeMessage();

        }
    }
}
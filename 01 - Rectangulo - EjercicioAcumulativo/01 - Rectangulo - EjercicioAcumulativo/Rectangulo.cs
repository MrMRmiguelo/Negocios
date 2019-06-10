using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace _01___Rectangulo___EjercicioAcumulativo
{
    class Rectangulo : INotifyPropertyChanged
    {
        private string x1;
        private string x2;
        private string y1;
        private string y2;
        private string verificar;
        public event PropertyChangedEventHandler PropertyChanged;
        public string X1
        {
            get { return x1; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);// verifica si es posible el resultado o no
                if (resultado) x1 = value;
                OnPropertyChanged("x1");
                OnPropertyChanged("Resultado");
            }
        }
        public string X2
        {   
            get { return X2; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);// verifica si es posible el resultado o no
                if (resultado) x2 = value;
                OnPropertyChanged("x1");
                OnPropertyChanged("Resultado");
            }
        }
        public string Y1
        {
            get { return y1; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);// verifica si es posible el resultado o no
                if (resultado) y1 = value;
                OnPropertyChanged("x1");
                OnPropertyChanged("Resultado");
            }
        }
        public string Y2
        {
            get { return y2; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);// verifica si es posible el resultado o no
                if (resultado) y2 = value;
                OnPropertyChanged("x1");
                OnPropertyChanged("Resultado");
            }
        }
        public string Verificar
        {
            get
            {
                double resultado1 = Double.Parse("x1") - Double.Parse(x2);
                double resultado2 = Double.Parse(y1) - Double.Parse(y2);
                double resultado3 = resultado1 * resultado1;
                double resultado4 = resultado2 * resultado2;
                double final = resultado3 + resultado4;
                double Raiz = Math.Sqrt(final);
                return Raiz.ToString();
            }
            set
            {
                double resultado1 = Double.Parse("x1") - Double.Parse(x2);
                double resultado2 = Double.Parse(y1) - Double.Parse(y2);
                double resultado3 = resultado1 * resultado1;
                double resultado4 = resultado2 * resultado2;
                double final = resultado3 + resultado4;
                double Raiz = Math.Sqrt(final);
                Verificar = verificar.ToString();
                OnPropertyChanged(Verificar);
            }
        }

        protected void OnPropertyChanged(string name)
        {

            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

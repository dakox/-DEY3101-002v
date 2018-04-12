using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBeLife
{
    class Cliente
    {
        private int _rut;
        private string _nombres;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private Sexo _sexo;
        private EstadoCivil _estadoCivil;

        public Cliente(int rut, string nombres, string apellidos, DateTime fechaNacimiento, Sexo sexo, EstadoCivil estadoCivil)
        {
            _rut = rut;
            _nombres = nombres;
            _apellidos = apellidos;
            _fechaNacimiento = fechaNacimiento;
            _sexo = sexo;
            _estadoCivil = estadoCivil;
        }

        public int Rut { get => _rut; set => _rut = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public Sexo Sexo { get => _sexo; set => _sexo = value; }
        public EstadoCivil EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
    }
}

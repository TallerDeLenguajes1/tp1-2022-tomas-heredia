using System;
using System.IO;
using System.Net;


namespace empleados.cs
{
    public class trabajador{
        public string nombre;


        private int dni;

        private DateTime nacimiento;

        private DateTime ingreso;

        private string direccion;

        private string datos;

        private float sueldo;

        public void set_nombre(string n){
            this.nombre = n;
        }

        public void set_dni(int n){
            this.dni = n;
        }

        public void set_nacimiento(DateTime n){
            this.nacimiento = n;
        }

        public void set_ingreso(DateTime n){
            this.ingreso = n;
        }

        public void set_direccion(string n){
            this.direccion = n;
        }

        public void set_datos(string n){
            this.datos = n;
        }

        public void set_nombre(float n){
            this.sueldo = n;
        }

        public string verNombre(){
            return this.nombre;
        }

        public string verDireccion(){
            return this.direccion;
        }

        public string verDatos(){
            return this.datos;
        }

        public float verSalario(){
            return this.salario;
        }

        public int veredad(){

            int edad = DateTime.Now.Year - this.nacimiento.Year;
            return edad;
        }

        public int verAntiguedad(){

            int edad = DateTime.Now.Year - this.ingreso.Year;
            return edad;
        }

        public float salario(){
            float salario = this.sueldo - this.sueldo*0.15;
            if (this.verAntiguedad < 25)
            {
                salario + salario*this.verAntiguedad*0.01;
            }else
            {
                salario + salario*0.25;
            }
            return salario;
        }

    }


}
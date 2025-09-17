using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformeseApp2.DTO
{
    public class CursoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int CargaHoraria { get; set; }

        public string Info() => $"Curso: {Nome}, Carga:{CargaHoraria}h";

        //Polimorfismo + Sobrecarga de método + Função Lambda + Função ternária
        //public string Info(bool chovendo) => chovendo ? $"levar guarda chuva" : $"deixar guarda chuva em casa";

        public string Info(bool detalhado) => detalhado ? $"[Curso Detalhado] {Nome} - {CargaHoraria}h" : Info();


          
            
}

        
    }

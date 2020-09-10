using System;
using System.Collections.Generic;
using System.Text;

namespace DPRN1_U3_AC_PIVM
{
    [Serializable()]
    class Encuesta
    {
        private string _Pregunta1 = "¿Te encuentras satisfecho con nuestro servicio? ";
        private int _respuesta1;
        private string _Pregunta2 = "¿Crees que nuestro menú es variado?";
        private int _respuesta2;
        private string _Pregunta3 = "¿Consideras que tardan en atenderte?";
        private int _respuesta3;
        private string _Pregunta4 = "¿Recibiste los que ordenaste?";
        private int _respuesta4;
        private string _Pregunta5 = "¿El alimento que recibiste cumplió con la calidad descrita en el menú?";
        private int _respuesta5;
        private string _Pregunta6 = "¿Crees que el precio del producto es adecuado a lo que recibiste?";
        private int _respuesta6;
        private string _Pregunta7 = "¿Cómo calificarías el ambiente del restaurante?";
        private int _respuesta7;
        private string _Pregunta8 = "¿Consideras que se cumplen los estándares de higiene?";
        private int _respuesta8;
        private string _Pregunta9 = "¿Cada cuando visitas nuestro restaurante?";
        private int _respuesta9;
        private string _Pregunta10 = "¿Por qué prefieres este restaurante sobre otros que ofrecen el mismo tipo de alimentos?";
        private int _respuesta10;

        public string Pregunta1 { get => _Pregunta1; set => _Pregunta1 = value; }
        public int Respuesta1 { get => _respuesta1; set => _respuesta1 = value; }
        public string Pregunta2 { get => _Pregunta2; set => _Pregunta2 = value; }
        public int Respuesta2 { get => _respuesta2; set => _respuesta2 = value; }
        public string Pregunta3 { get => _Pregunta3; set => _Pregunta3 = value; }
        public int Respuesta3 { get => _respuesta3; set => _respuesta3 = value; }
        public string Pregunta4 { get => _Pregunta4; set => _Pregunta4 = value; }
        public int Respuesta4 { get => _respuesta4; set => _respuesta4 = value; }
        public string Pregunta5 { get => _Pregunta5; set => _Pregunta5 = value; }
        public int Respuesta5 { get => _respuesta5; set => _respuesta5 = value; }
        public string Pregunta6 { get => _Pregunta6; set => _Pregunta6 = value; }
        public int Respuesta6 { get => _respuesta6; set => _respuesta6 = value; }
        public string Pregunta7 { get => _Pregunta7; set => _Pregunta7 = value; }
        public int Respuesta7 { get => _respuesta7; set => _respuesta7 = value; }
        public string Pregunta8 { get => _Pregunta8; set => _Pregunta8 = value; }
        public int Respuesta8 { get => _respuesta8; set => _respuesta8 = value; }
        public string Pregunta9 { get => _Pregunta9; set => _Pregunta9 = value; }
        public int Respuesta9 { get => _respuesta9; set => _respuesta9 = value; }
        public string Pregunta10 { get => _Pregunta10; set => _Pregunta10 = value; }
        public int Respuesta10 { get => _respuesta10; set => _respuesta10 = value; }
    }
}

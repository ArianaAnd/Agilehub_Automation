using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Curs
    {
        private int _cursId { get; set;}
        private string _Nume{ get; set;}
        private int _durata{ get; set;}

        public Curs(int cursId, string Nume, int durata)
        {
            _cursId = cursId;
            _Nume = Nume;
            _durata = durata;
        }
        //~Curs()
        //{
        //    Console.WriteLine("I am a destructor");
        //}

        //public void SetareCurs(int idCurs, string numeCurs, int durataCurs)
        //{
        //    cursId = idCurs;
        //    Nume = numeCurs;
        //    Durata = durataCurs;


        //}

        //public void SetCursId(int cursId)
        //{
        //    _cursId = cursId;
        //}
        //public int GetCursId()
        //{
        //    return _cursId;
        //}

        //public string NumeCurs()
        //{
        //    return Nume; 
        //}
    }

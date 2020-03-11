using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Bog
    {


        private int _sidetal;
        private string _forfatter;
        private string _isbn13;

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length < 13 || value.Length > 13) throw new ArgumentOutOfRangeException();
                {
                    _isbn13 = value;
                }
            }
        }

        public string Forfatter
        {
            get => _forfatter;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                {
                    _forfatter = value;
                }
            }

        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value < 4 || value > 1000) throw new ArgumentOutOfRangeException();
                {
                    _sidetal = value;
                }
            }

        }





        public Bog()
        {

        }

        public Bog(string Isbn13, string Forfatter, int Sidetal)
        {
            _isbn13 = Isbn13;
            _forfatter = Forfatter;
            _sidetal = Sidetal;

        }

        public override string ToString()
        {
            return _isbn13 + " " + _forfatter + " " + _sidetal + " ";
        }



    }



}
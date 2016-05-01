using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HQ40d_Diagnosztika
{
    //Koordináta adatok osztálya
    class Koordinata
    {
        private int _ht1VezkX;
        private int _ht1VezkY;
        private int _ht1KemhX;
        private int _ht1KemhY;

        private int _ht2VezkX;
        private int _ht2VezkY;
        private int _ht2KemhX;
        private int _ht2KemhY;

        private int _ht3VezkX;
        private int _ht3VezkY;
        private int _ht3KemhX;
        private int _ht3KemhY;

        private int _ht4VezkX;
        private int _ht4VezkY;
        private int _ht4KemhX;
        private int _ht4KemhY;

        private int _ht5VezkX;
        private int _ht5VezkY;
        private int _ht5KemhX;
        private int _ht5KemhY;

        private int _ht6VezkX;
        private int _ht6VezkY;
        private int _ht6KemhX;
        private int _ht6KemhY;

        private int _ht7VezkX;
        private int _ht7VezkY;
        private int _ht7KemhX;
        private int _ht7KemhY;

        private int _ht8VezkX;
        private int _ht8VezkY;
        private int _ht8KemhX;
        private int _ht8KemhY;

        private int _ht9VezkX;
        private int _ht9VezkY;
        private int _ht9KemhX;
        private int _ht9KemhY;

        private int _ht10VezkX;
        private int _ht10VezkY;
        private int _ht10KemhX;
        private int _ht10KemhY;

        private int _potvizVezkX;
        private int _potvizVezkY;
        private int _potvizKemhX;
        private int _potvizKemhY;

        private int _hutesiVezkX;
        private int _hutesiVezkY;
        private int _hutesiKemhX;
        private int _hutesiKemhY;

        private int _kondenzVezkX;
        private int _kondenzVezkY;
        private int _kondenzKemhX;
        private int _kondenzKemhY;

        private int _nyersvizVezkX;
        private int _nyersvizVezkY;
        private int _nyersvizKemhX;
        private int _nyersvizKemhY;

        private int _duo10VezkX;
        private int _duo10VezkY;
        private int _duo10KemhX;
        private int _duo10KemhY;

        public Koordinata() { }

        public int ht1VX
        {
            get { return _ht1VezkX; }
            set { _ht1VezkX = value; }
        }
            
        public int ht1VY
        {
            get { return _ht1VezkY; }
            set { _ht1VezkY = value; }
        }

        public int ht1KX
        {
            get { return _ht1KemhX; }
            set { _ht1KemhX = value; }
        }

        public int ht1KY
        {
            get { return _ht1KemhY; }
            set { _ht1KemhY = value; }
        }

        public int ht2VX
        {
            get { return _ht2VezkX; }
            set { _ht2VezkX = value; }
        }

        public int ht2VY
        {
            get { return _ht2VezkY; }
            set { _ht2VezkY = value; }
        }

        public int ht2KX
        {
            get { return _ht2KemhX; }
            set { _ht2KemhX = value; }
        }

        public int ht2KY
        {
            get { return _ht2KemhY; }
            set { _ht2KemhY = value; }
        }

        public int ht3VX
        {
            get { return _ht3VezkX; }
            set { _ht3VezkX = value; }
        }

        public int ht3VY
        {
            get { return _ht3VezkY; }
            set { _ht3VezkY = value; }
        }

        public int ht3KX
        {
            get { return _ht3KemhX; }
            set { _ht3KemhX = value; }
        }

        public int ht3KY
        {
            get { return _ht3KemhY; }
            set { _ht3KemhY = value; }
        }

        public int ht4VX
        {
            get { return _ht4VezkX; }
            set { _ht4VezkX = value; }
        }

        public int ht4VY
        {
            get { return _ht4VezkY; }
            set { _ht4VezkY = value; }
        }

        public int ht4KX
        {
            get { return _ht4KemhX; }
            set { _ht4KemhX = value; }
        }

        public int ht4KY
        {
            get { return _ht4KemhY; }
            set { _ht4KemhY = value; }
        }

        public int ht5VX
        {
            get { return _ht5VezkX; }
            set { _ht5VezkX = value; }
        }

        public int ht5VY
        {
            get { return _ht5VezkY; }
            set { _ht5VezkY = value; }
        }

        public int ht5KX
        {
            get { return _ht5KemhX; }
            set { _ht5KemhX = value; }
        }

        public int ht5KY
        {
            get { return _ht5KemhY; }
            set { _ht5KemhY = value; }
        }

        public int ht6VX
        {
            get { return _ht6VezkX; }
            set { _ht6VezkX = value; }
        }

        public int ht6VY
        {
            get { return _ht6VezkY; }
            set { _ht6VezkY = value; }
        }

        public int ht6KX
        {
            get { return _ht6KemhX; }
            set { _ht6KemhX = value; }
        }

        public int ht6KY
        {
            get { return _ht6KemhY; }
            set { _ht6KemhY = value; }
        }

        public int ht7VX
        {
            get { return _ht7VezkX; }
            set { _ht7VezkX = value; }
        }

        public int ht7VY
        {
            get { return _ht7VezkY; }
            set { _ht7VezkY = value; }
        }

        public int ht7KX
        {
            get { return _ht7KemhX; }
            set { _ht7KemhX = value; }
        }

        public int ht7KY
        {
            get { return _ht7KemhY; }
            set { _ht7KemhY = value; }
        }

        public int ht8VX
        {
            get { return _ht8VezkX; }
            set { _ht8VezkX = value; }
        }

        public int ht8VY
        {
            get { return _ht8VezkY; }
            set { _ht8VezkY = value; }
        }

        public int ht8KX
        {
            get { return _ht8KemhX; }
            set { _ht8KemhX = value; }
        }

        public int ht8KY
        {
            get { return _ht8KemhY; }
            set { _ht8KemhY = value; }
        }

        public int ht9VX
        {
            get { return _ht9VezkX; }
            set { _ht9VezkX = value; }
        }

        public int ht9VY
        {
            get { return _ht9VezkY; }
            set { _ht9VezkY = value; }
        }

        public int ht9KX
        {
            get { return _ht9KemhX; }
            set { _ht9KemhX = value; }
        }

        public int ht9KY
        {
            get { return _ht9KemhY; }
            set { _ht9KemhY = value; }
        }

        public int ht10VX
        {
            get { return _ht10VezkX; }
            set { _ht10VezkX = value; }
        }

        public int ht10VY
        {
            get { return _ht10VezkY; }
            set { _ht10VezkY = value; }
        }

        public int ht10KX
        {
            get { return _ht10KemhX; }
            set { _ht10KemhX = value; }
        }

        public int ht10KY
        {
            get { return _ht10KemhY; }
            set { _ht10KemhY = value; }
        }

        public int potvizVX
        {
            get { return _potvizVezkX; }
            set { _potvizVezkX = value; }
        }

        public int potvizVY
        {
            get { return _potvizVezkY; }
            set { _potvizVezkY = value; }
        }

        public int potvizKX
        {
            get { return _potvizKemhX; }
            set { _potvizKemhX = value; }
        }

        public int potvizKY
        {
            get { return _potvizKemhY; }
            set { _potvizKemhY = value; }
        }

        public int hutesiVX
        {
            get { return _hutesiVezkX; }
            set { _hutesiVezkX = value; }
        }

        public int hutesiVY
        {
            get { return _hutesiVezkY; }
            set { _hutesiVezkY = value; }
        }

        public int hutesiKX
        {
            get { return _hutesiKemhX; }
            set { _hutesiKemhX = value; }
        }

        public int hutesiKY
        {
            get { return _hutesiKemhY; }
            set { _hutesiKemhY = value; }
        }

        public int kondenzVX
        {
            get { return _kondenzVezkX; }
            set { _kondenzVezkX = value; }
        }

        public int kondenzVY
        {
            get { return _kondenzVezkY; }
            set { _kondenzVezkY = value; }
        }

        public int kondenzKX
        {
            get { return _kondenzKemhX; }
            set { _kondenzKemhX = value; }
        }

        public int kondenzKY
        {
            get { return _kondenzKemhY; }
            set { _kondenzKemhY = value; }
        }

        public int nyersvizVX
        {
            get { return _nyersvizVezkX; }
            set { _nyersvizVezkX = value; }
        }

        public int nyersvizVY
        {
            get { return _nyersvizVezkY; }
            set { _nyersvizVezkY = value; }
        }

        public int nyersvizKX
        {
            get { return _nyersvizKemhX; }
            set { _nyersvizKemhX = value; }
        }

        public int nyersvizKY
        {
            get { return _nyersvizKemhY; }
            set { _nyersvizKemhY = value; }
        }

        public int duo10VX
        {
            get { return _duo10VezkX; }
            set { _duo10VezkX = value; }
        }

        public int duo10VY
        {
            get { return _duo10VezkY; }
            set { _duo10VezkY = value; }
        }

        public int duo10KX
        {
            get { return _duo10KemhX; }
            set { _duo10KemhX = value; }
        }

        public int duo10KY
        {
            get { return _duo10KemhY; }
            set { _duo10KemhY = value; }
        }
    }
}

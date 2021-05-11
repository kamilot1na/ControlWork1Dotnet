using System;
using System.Data.Common;

namespace ControlWork1
{
    public class Bird
    {
        public Bird()
        {
            
        }
        public int Id { get; set; }
        public int Speed { get; set; }
        
        public bool isNailed { get; set; }
        private int getBaseSpeed()
        {
            return Speed;
        }

        public Bird(int _Id, int _Speed, bool _isNailed)
        {
            Id = _Id;
            Speed = _Speed;
            isNailed = _isNailed;
        }
        
        public double getSpeed(int Id) {
            switch (Id) {
                case 1:
                    return getBaseSpeed();
                case 2:
                    return getBaseSpeed() - 5;
                case 3:
                    return (isNailed) ? 0 : getBaseSpeed();
            }
            throw new NotImplementedException("Should be unreachable");
        }
    }
}
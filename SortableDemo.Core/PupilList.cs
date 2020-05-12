using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OwnArrayList.Core
{
    public class PupilList
    {
        private int _nextIndex;
        private Pupil[] _pupils;

        public int Count
        {
            get { return _nextIndex; }
        }

        public int NextIndex
        {
            get { return _nextIndex; }
            set { _nextIndex = value; }
        }

        public PupilList()
        {
            _nextIndex = 0;
            _pupils = new Pupil[_nextIndex];
        }

        public void Add(Pupil pupil)
        {
            Insert(_nextIndex, pupil);
        }

        public void RemoveAt(int index)
        {
            Remove(GetAt(index));
        }

        public bool Remove(Pupil pupil)
        {
            bool wasSuccess;
            int index = 0;
            while (index < _pupils.Length - 1 && !pupil.Equals(_pupils[index]))
            {
                index++;
            }

            if (_pupils[index].Equals(pupil))
            {
                for (int i = index; i < _pupils.Length - 1; i++)
                {
                    _pupils[i] = _pupils[i + 1];
                }
                _pupils[_pupils.Length - 1] = null;
                _nextIndex--;
                wasSuccess = true;
            }
            else
            {
                wasSuccess = false;
            }

            return wasSuccess;
        }

        public Pupil GetAt(int index)
        {
            return _pupils[index];
        }

        public void Insert(int index, Pupil pupil)
        {
            if (_pupils.Length == 0)//0er-Array
            {
                _pupils = new Pupil[_nextIndex + 1];
                _pupils[_nextIndex] = pupil;
            }
            else if (_pupils[_pupils.Length - 1] == null)//Leeres Ende
            {
                for (int i = _pupils.Length - 1; i > index; i--)
                {
                    if (_pupils[i] != null)
                    {
                        _pupils[i + 1] = _pupils[i];
                    }
                }
                _pupils[index] = pupil;
            }
            else//Volles Ende 1,2
            {
                int i = 0;
                bool wasNotInMiddle = true;
                Pupil[] temp = new Pupil[_pupils.Length + 1];
                while (i < _pupils.Length)
                {
                    temp[i] = _pupils[i];
                    if (i == index)
                    {
                        temp[i] = pupil;
                        temp[i + 1] = _pupils[i];
                        i++;
                        wasNotInMiddle = false;
                        continue;
                    }
                    i++;
                }
                if (wasNotInMiddle)
                {
                    temp[i] = pupil;
                }
                _pupils = temp;
            }
            _nextIndex++;
        }

        public void Sort()
        {
            int length = _pupils.Length;
            Pupil temp = _pupils[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (_pupils[i].Age > _pupils[j].Age)
                    {
                        temp = _pupils[i];

                        _pupils[i] = _pupils[j];

                        _pupils[j] = temp;
                    }
                }
            }
        }
    }
}
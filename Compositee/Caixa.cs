using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Compositee
{
    public class Caixa : IItem
    {
        private IList<IItem> _items;
        public Caixa()
        {
            _items = new List<IItem>();
        }
        
        public int ItemList { get; }
        
        public float GetVolume()
        {
            float value = 0;
            foreach (var item in _items)
            {
                value += item.GetVolume();
            }

            if (value < 5)
            {
                return 5;
                
            }else if (value < 10)
            {
                return 10;
            }
            else
            {
                return 100;
            }
            
        }

        public float GetPrice()
        {
            float value = 0;
            foreach (var item in _items)
            {
                value += item.GetPrice();
            }

            return value + 0.5f;
        }
    }
}
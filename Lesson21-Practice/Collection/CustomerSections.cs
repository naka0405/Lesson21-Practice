﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSection
{
     public class CustomerSections:Collection<Section>
    {
        public Section this[string indexName]=>this.Items.First(x=>string.Equals(x.Name,indexName));
        public IEnumerable<string> AllSectionsByName => Items.Select(s => s.Name);
        protected override void InsertItem(int index, Section item)
        {
            if (item.Cost > 0)
            {
                base.InsertItem(index, item);
            }
            else
            {
                Console.WriteLine($"Specified cost isn't valid: {item.Cost}");
            }
        }
        public void ForEach(Action<string> action)
        {
            foreach (var item in Items)
            {
                action($"Section name is: {item.Name} and cost: {item.Cost}");
            }
        }
    }
}

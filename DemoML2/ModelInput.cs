using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoML2
{
    public class ModelInput
    {
        [ColumnName(@"col0")]
        public string Col0 { get; set; }

        [ColumnName(@"col1")]
        public float Col1 { get; set; }

    }
}

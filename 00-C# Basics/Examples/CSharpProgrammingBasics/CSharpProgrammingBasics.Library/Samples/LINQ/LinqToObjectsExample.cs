using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CSharpProgrammingBasics.Library.Samples.LINQ
{
    class LinqToObjectsExample
    {
        public IEnumerable FilterList(int threshold)
        {
	        List<int> _dataSet = new List<int>() { 1, 5, 9, 2, 4, 3, 6, 8, 7, 0};
	        var _result = 	
                        from _i in _dataSet
			 	        where _i > threshold
                        orderby (_i % 2) descending
                        select _i;
	        return _result;
        }
    }
}

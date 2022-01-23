using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LowisChartApp.model
{
    public class MyCache
    {
        private readonly string _KeyFieldName;
        Dictionary<object, object> valuesCache = new Dictionary<object, object>();

        public MyCache(string keyFieldName)
        {
            _KeyFieldName = keyFieldName;
        }

        public object GetKeyByRow(object row)
        {
            return (row as DataRowView)[_KeyFieldName];
        }


        public object GetValue(object row)
        {
            return GetValueByKey(GetKeyByRow(row));
        }

        public object GetValueByKey(object key)
        {
            object result = null;
            valuesCache.TryGetValue(key, out result);
            return result;
        }


        public void SetValue(object row, object value)
        {
            SetValueByKey(GetKeyByRow(row), value);
        }

        public void SetValueByKey(object key, object value)
        {
            valuesCache[key] = value;
        }
    }
}
